// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Actions"",
            ""id"": ""0f2dc023-1694-464f-9c61-cda43719cd05"",
            ""actions"": [
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""e90d533a-d517-4f3f-8d13-830fcbeab16c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""0673adbc-82c0-409d-9ed4-7ff6f1255eb2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot1"",
                    ""type"": ""Button"",
                    ""id"": ""634901cb-2e54-47b0-99be-0927811dc16b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot2"",
                    ""type"": ""Button"",
                    ""id"": ""e07a6f5c-8517-4201-9337-28f8ef150f89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot3"",
                    ""type"": ""Button"",
                    ""id"": ""acdac7b9-28f8-4e38-b569-9590a1652cc7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot4"",
                    ""type"": ""Button"",
                    ""id"": ""22943604-ef19-4574-acee-b5795db8f631"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""d573135f-2459-46c1-a47c-0ca2930c912a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""8747c435-1878-4ced-8785-5742ffb1d23b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""df38961e-f878-42e1-8f11-93978cc4e926"",
                    ""path"": ""<Gamepad>/dpad/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Throttle"",
                    ""id"": ""ff7b259c-9d26-429e-a812-b1eaaf9e5663"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""76cec267-38e7-4b0c-abb7-330a3639145b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0462ddd6-58d1-452f-b76e-a7b3535ec56a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Throttle"",
                    ""id"": ""da9b0ab7-b4f7-4430-8cd7-c54323ce89a8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1d5a6daf-8282-46ad-870f-9528bca3950a"",
                    ""path"": ""<Keyboard>/quote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""72887011-a5dc-4621-a871-912b9cb36b1d"",
                    ""path"": ""<Keyboard>/leftBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f71a2490-3224-4c2d-b154-2ed435c302d4"",
                    ""path"": ""<Gamepad>/dpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""dc75b37e-3e73-4fbf-b162-e4faa30cfae0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9c7cd7e0-af36-4254-bb55-5422a90dcaa5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a1c27433-3363-4476-9ab3-90b8685ae278"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6ffea0af-1119-4ca7-a129-5b00a4549cb2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e2fb1e30-5314-4618-9244-9984199e8f6e"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2fae5334-d7ef-4def-8521-2a49e1cb365a"",
                    ""path"": ""<Keyboard>/backslash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""32f4bbd0-904d-4701-b06f-22d13d1e773a"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69b91ddd-0b65-4cbc-9ef8-b2eaee69b3d0"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPrimary"",
                    ""action"": ""Shoot1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc64fef0-39ed-4206-b02a-260c60a2ef70"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Shoot1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a82cc642-eb0d-482e-b95b-76776c63f9ea"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e6483ba-07ca-43de-8700-9ca959130db6"",
                    ""path"": ""<Keyboard>/quote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f08ec01-994b-4c57-bd8f-f46c36dbdfdf"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPrimary"",
                    ""action"": ""Shoot3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51f83f42-a599-487c-8c63-8d3a8d82d761"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Shoot3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ecb4cdea-2194-47a1-943f-aa4f031b792f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""cb4473c7-5172-4074-81e5-942823e12df6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6480300a-50bd-400c-8fe2-a7ee558d13fa"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d9e2b183-be7c-4cad-9f66-f074dd5fb590"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Aim"",
                    ""id"": ""6b571660-5c85-4a90-9869-c104ceabcdbc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""36977748-f16a-4a06-8019-98942fe85b2b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bf4a2a41-e8e4-4c1f-a38d-affd9feef4e8"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Aim"",
                    ""id"": ""7f4d99a1-36e3-43ee-820b-d093373c95ea"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a7670562-440a-4ab9-9177-fd3edc871799"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""75ee5101-2257-429a-886f-a700a30219a9"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e27247ad-acab-4c4e-b1d0-6e57267a61bb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary;KeyboardSecondary"",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d355eb2f-cbd6-4458-a199-30f211c68758"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa0e4d98-55e4-4bce-aba3-99d8780cde75"",
                    ""path"": ""<Keyboard>/backslash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cbdac11-fedc-4911-ab7e-94533464c62f"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPrimary"",
                    ""action"": ""Shoot4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c74bff50-9ea4-4ac8-956a-c0d6a85e7b75"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Shoot4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""daaeda59-a61c-4352-931e-6beb0aa1321b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d31b4251-5663-4146-8585-418feacc1d87"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72f641f6-4bcb-434f-8ab7-19ce7186ea22"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPrimary"",
                    ""action"": ""Shoot2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c93be600-e7a9-4773-8a39-8d22e358bf1c"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Shoot2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bf8c900-6768-4a3f-9ac4-f6c94ff7b471"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MainMenu"",
            ""id"": ""859a399f-6f1c-4e41-ad78-03e3db5cc3d1"",
            ""actions"": [
                {
                    ""name"": ""Ready"",
                    ""type"": ""Button"",
                    ""id"": ""13478067-39d8-4228-af96-e2b1903e3436"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""50756015-06bd-4eae-9c47-51cb4c8e4c8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Previous"",
                    ""type"": ""Button"",
                    ""id"": ""14cbce9a-bdeb-4e87-92a8-01b24e0c991a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Unready"",
                    ""type"": ""Button"",
                    ""id"": ""2dc0247c-c031-4741-91f7-f6b28049ffc7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player2Join"",
                    ""type"": ""Button"",
                    ""id"": ""0f77a480-0975-481f-b9ea-c9df386cdb7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""43d294a6-5ce8-4abe-8dbd-6cf14ebd100c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c1eb0cd7-2ce9-4a09-89d4-8ac25fa6b6ba"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Ready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a3f2e9e-3653-4ff3-a350-347a9d1b68a1"",
                    ""path"": ""<Keyboard>/leftBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Ready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fa4d0c1-b519-4b10-bfda-e3229fd13017"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Ready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8bd2942-0a3f-4500-b1d7-c5e7ef089e3f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""583985a7-da4f-45f9-9cec-cf38af717aa2"",
                    ""path"": ""<Keyboard>/backslash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b8c7245-48be-4385-82cf-a658dc6f4f0d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94241a7b-e3d3-4135-bfa3-6a876ff022d8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e155e0d-8786-4a13-a0b6-62944dc9be04"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd3056bb-9738-471c-a77e-2039e1ec9a9d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d23c2134-7405-4754-a9f1-63451d7ce4a8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Unready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f581454b-e861-4b60-9c1e-edbad8483f88"",
                    ""path"": ""<Keyboard>/quote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardSecondary"",
                    ""action"": ""Unready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f48aff7a-0489-48b7-8910-03edb0c33a4e"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Unready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf7039a9-f157-4fa9-a01c-eb442caafc47"",
                    ""path"": ""<Keyboard>/leftBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary"",
                    ""action"": ""Player2Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6bfeb2c-e323-4168-98fa-06ff3df32859"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;KeyboardPrimary;KeyboardSecondary"",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""faa900cd-9f21-4998-94be-1fbe3d65b037"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardSecondary"",
            ""bindingGroup"": ""KeyboardSecondary"",
            ""devices"": []
        },
        {
            ""name"": ""KeyboardPrimary"",
            ""bindingGroup"": ""KeyboardPrimary"",
            ""devices"": []
        }
    ]
}");
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Throttle = m_Actions.FindAction("Throttle", throwIfNotFound: true);
        m_Actions_Steering = m_Actions.FindAction("Steering", throwIfNotFound: true);
        m_Actions_Shoot1 = m_Actions.FindAction("Shoot1", throwIfNotFound: true);
        m_Actions_Shoot2 = m_Actions.FindAction("Shoot2", throwIfNotFound: true);
        m_Actions_Shoot3 = m_Actions.FindAction("Shoot3", throwIfNotFound: true);
        m_Actions_Shoot4 = m_Actions.FindAction("Shoot4", throwIfNotFound: true);
        m_Actions_Aim = m_Actions.FindAction("Aim", throwIfNotFound: true);
        m_Actions_Quit = m_Actions.FindAction("Quit", throwIfNotFound: true);
        // MainMenu
        m_MainMenu = asset.FindActionMap("MainMenu", throwIfNotFound: true);
        m_MainMenu_Ready = m_MainMenu.FindAction("Ready", throwIfNotFound: true);
        m_MainMenu_Next = m_MainMenu.FindAction("Next", throwIfNotFound: true);
        m_MainMenu_Previous = m_MainMenu.FindAction("Previous", throwIfNotFound: true);
        m_MainMenu_Unready = m_MainMenu.FindAction("Unready", throwIfNotFound: true);
        m_MainMenu_Player2Join = m_MainMenu.FindAction("Player2Join", throwIfNotFound: true);
        m_MainMenu_Quit = m_MainMenu.FindAction("Quit", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_Throttle;
    private readonly InputAction m_Actions_Steering;
    private readonly InputAction m_Actions_Shoot1;
    private readonly InputAction m_Actions_Shoot2;
    private readonly InputAction m_Actions_Shoot3;
    private readonly InputAction m_Actions_Shoot4;
    private readonly InputAction m_Actions_Aim;
    private readonly InputAction m_Actions_Quit;
    public struct ActionsActions
    {
        private @PlayerControls m_Wrapper;
        public ActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_Actions_Throttle;
        public InputAction @Steering => m_Wrapper.m_Actions_Steering;
        public InputAction @Shoot1 => m_Wrapper.m_Actions_Shoot1;
        public InputAction @Shoot2 => m_Wrapper.m_Actions_Shoot2;
        public InputAction @Shoot3 => m_Wrapper.m_Actions_Shoot3;
        public InputAction @Shoot4 => m_Wrapper.m_Actions_Shoot4;
        public InputAction @Aim => m_Wrapper.m_Actions_Aim;
        public InputAction @Quit => m_Wrapper.m_Actions_Quit;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @Throttle.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnThrottle;
                @Steering.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSteering;
                @Shoot1.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot1;
                @Shoot1.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot1;
                @Shoot1.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot1;
                @Shoot2.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot2;
                @Shoot2.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot2;
                @Shoot2.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot2;
                @Shoot3.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot3;
                @Shoot3.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot3;
                @Shoot3.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot3;
                @Shoot4.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot4;
                @Shoot4.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot4;
                @Shoot4.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShoot4;
                @Aim.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAim;
                @Quit.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnQuit;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Shoot1.started += instance.OnShoot1;
                @Shoot1.performed += instance.OnShoot1;
                @Shoot1.canceled += instance.OnShoot1;
                @Shoot2.started += instance.OnShoot2;
                @Shoot2.performed += instance.OnShoot2;
                @Shoot2.canceled += instance.OnShoot2;
                @Shoot3.started += instance.OnShoot3;
                @Shoot3.performed += instance.OnShoot3;
                @Shoot3.canceled += instance.OnShoot3;
                @Shoot4.started += instance.OnShoot4;
                @Shoot4.performed += instance.OnShoot4;
                @Shoot4.canceled += instance.OnShoot4;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);

    // MainMenu
    private readonly InputActionMap m_MainMenu;
    private IMainMenuActions m_MainMenuActionsCallbackInterface;
    private readonly InputAction m_MainMenu_Ready;
    private readonly InputAction m_MainMenu_Next;
    private readonly InputAction m_MainMenu_Previous;
    private readonly InputAction m_MainMenu_Unready;
    private readonly InputAction m_MainMenu_Player2Join;
    private readonly InputAction m_MainMenu_Quit;
    public struct MainMenuActions
    {
        private @PlayerControls m_Wrapper;
        public MainMenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Ready => m_Wrapper.m_MainMenu_Ready;
        public InputAction @Next => m_Wrapper.m_MainMenu_Next;
        public InputAction @Previous => m_Wrapper.m_MainMenu_Previous;
        public InputAction @Unready => m_Wrapper.m_MainMenu_Unready;
        public InputAction @Player2Join => m_Wrapper.m_MainMenu_Player2Join;
        public InputAction @Quit => m_Wrapper.m_MainMenu_Quit;
        public InputActionMap Get() { return m_Wrapper.m_MainMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMenuActions set) { return set.Get(); }
        public void SetCallbacks(IMainMenuActions instance)
        {
            if (m_Wrapper.m_MainMenuActionsCallbackInterface != null)
            {
                @Ready.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnReady;
                @Ready.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnReady;
                @Ready.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnReady;
                @Next.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnNext;
                @Previous.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnPrevious;
                @Previous.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnPrevious;
                @Previous.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnPrevious;
                @Unready.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnUnready;
                @Unready.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnUnready;
                @Unready.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnUnready;
                @Player2Join.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnPlayer2Join;
                @Player2Join.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnPlayer2Join;
                @Player2Join.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnPlayer2Join;
                @Quit.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnQuit;
            }
            m_Wrapper.m_MainMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Ready.started += instance.OnReady;
                @Ready.performed += instance.OnReady;
                @Ready.canceled += instance.OnReady;
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
                @Previous.started += instance.OnPrevious;
                @Previous.performed += instance.OnPrevious;
                @Previous.canceled += instance.OnPrevious;
                @Unready.started += instance.OnUnready;
                @Unready.performed += instance.OnUnready;
                @Unready.canceled += instance.OnUnready;
                @Player2Join.started += instance.OnPlayer2Join;
                @Player2Join.performed += instance.OnPlayer2Join;
                @Player2Join.canceled += instance.OnPlayer2Join;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
            }
        }
    }
    public MainMenuActions @MainMenu => new MainMenuActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_KeyboardSecondarySchemeIndex = -1;
    public InputControlScheme KeyboardSecondaryScheme
    {
        get
        {
            if (m_KeyboardSecondarySchemeIndex == -1) m_KeyboardSecondarySchemeIndex = asset.FindControlSchemeIndex("KeyboardSecondary");
            return asset.controlSchemes[m_KeyboardSecondarySchemeIndex];
        }
    }
    private int m_KeyboardPrimarySchemeIndex = -1;
    public InputControlScheme KeyboardPrimaryScheme
    {
        get
        {
            if (m_KeyboardPrimarySchemeIndex == -1) m_KeyboardPrimarySchemeIndex = asset.FindControlSchemeIndex("KeyboardPrimary");
            return asset.controlSchemes[m_KeyboardPrimarySchemeIndex];
        }
    }
    public interface IActionsActions
    {
        void OnThrottle(InputAction.CallbackContext context);
        void OnSteering(InputAction.CallbackContext context);
        void OnShoot1(InputAction.CallbackContext context);
        void OnShoot2(InputAction.CallbackContext context);
        void OnShoot3(InputAction.CallbackContext context);
        void OnShoot4(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
    }
    public interface IMainMenuActions
    {
        void OnReady(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnPrevious(InputAction.CallbackContext context);
        void OnUnready(InputAction.CallbackContext context);
        void OnPlayer2Join(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
    }
}
