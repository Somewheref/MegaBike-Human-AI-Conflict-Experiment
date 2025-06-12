using UnityEngine;
using OpenAI;
using Sirenix.OdinInspector;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KayphoonStudio;

public class GPT_Interface_Base : MonoBehaviour
{
    [Title("GPT Configuration")]
    public GPT_Config_SO gptConfig;
    public string gptKey => gptConfig.gptKey;
    public string model => gptConfig.model;

    protected OpenAIApi openai;

    void Awake()
    {
        if (gptConfig == null)
        {
            KS_Logger.LogError("GPT_Config_SO is not assigned in the inspector!");
            return;
        }

        openai = new OpenAIApi(gptKey);
    }

    /// <summary>
    /// Sends a chat message to the GPT model and returns the response.
    /// /// </summary>
    public async void SendChatMessage(string message, Action<string> onResponseReceived, bool isJsonFormat = true)
    {
        if (openai == null)
        {
            KS_Logger.LogError("OpenAIApi is not initialized!");
            return;
        }

        var req = new CreateChatCompletionRequest
        {
            Model = model,
            Messages = new List<ChatMessage>
            {
                new ChatMessage
                {
                    Role = "user",
                    Content = message
                }
            }
        };

        try
        {
            var res = await openai.CreateChatCompletion(req);
            if (res.Choices.Count > 0)
            {
                string receivedResponse = res.Choices[0].Message.Content;
                KS_Logger.Log($"[GPT Response]: {receivedResponse}");
                if (isJsonFormat)
                {
                    receivedResponse = CleanJsonResponse(receivedResponse);
                }
                onResponseReceived?.Invoke(receivedResponse);
            }
            else
            {
                KS_Logger.LogWarning("No choices returned from GPT response.");
            }
        }
        catch (Exception ex)
        {
            KS_Logger.LogError($"Error sending chat message: {ex.Message}");
        }
    }

    public string CleanJsonResponse(string response)
    {
        if (string.IsNullOrEmpty(response))
        {
            KS_Logger.LogError("Response is null or empty!");
            return string.Empty;
        }

        // Remove any leading/trailing whitespace, ```, and ensure it ends with a closing brace.
        response = response.Trim().Trim('`').TrimStart("json".ToCharArray()).TrimEnd("json".ToCharArray()).Trim();
        if (!response.EndsWith("}"))
        {
            response += "}";
        }

        // Ensure the response is valid JSON.
        try
        {
            JsonConvert.DeserializeObject(response);
        }
        catch (JsonException ex)
        {
            KS_Logger.LogError($"Invalid JSON response: {ex.Message}");
            return string.Empty;
        }

        return response;
    }
}
