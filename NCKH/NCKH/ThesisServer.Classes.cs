/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace ThesisServer
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public const uint Plant1 = 15036;

        /// <summary>
        /// The identifier for the Plant1_System1 Object.
        /// </summary>
        public const uint Plant1_System1 = 15039;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice = 15040;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200 Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200 = 15041;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters = 15042;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100 Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100 = 15081;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters = 15082;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton = 15093;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StartButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton_StartButton = 15094;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StopButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton_StopButton = 15096;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ResetButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton_ResetButton = 15098;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ModeButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton_ModeButton = 15100;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController Object.
        /// </summary>
        public const uint Plant1_System1_SpeedController = 15102;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public const uint GenericControllerType = 15001;

        /// <summary>
        /// The identifier for the AnalogInputType ObjectType.
        /// </summary>
        public const uint AnalogInputType = 15006;

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public const uint AnalogOutputType = 15017;

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public const uint DigitalType = 15019;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 15021;

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public const uint AnalogSensorType = 15023;

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public const uint ButtonType = 15034;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public const uint GenericControllerType_SetPoint = 15002;

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public const uint GenericControllerType_Kp = 15003;

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public const uint GenericControllerType_Ki = 15004;

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public const uint GenericControllerType_Kd = 15005;

        /// <summary>
        /// The identifier for the AnalogInputType_Output Variable.
        /// </summary>
        public const uint AnalogInputType_Output = 15007;

        /// <summary>
        /// The identifier for the AnalogInputType_Ampere Variable.
        /// </summary>
        public const uint AnalogInputType_Ampere = 15008;

        /// <summary>
        /// The identifier for the AnalogInputType_AmpereStatus Variable.
        /// </summary>
        public const uint AnalogInputType_AmpereStatus = 15009;

        /// <summary>
        /// The identifier for the AnalogInputType_Volt Variable.
        /// </summary>
        public const uint AnalogInputType_Volt = 15010;

        /// <summary>
        /// The identifier for the AnalogInputType_VoltStatus Variable.
        /// </summary>
        public const uint AnalogInputType_VoltStatus = 15011;

        /// <summary>
        /// The identifier for the AnalogInputType_Frequency Variable.
        /// </summary>
        public const uint AnalogInputType_Frequency = 15012;

        /// <summary>
        /// The identifier for the AnalogInputType_Power Variable.
        /// </summary>
        public const uint AnalogInputType_Power = 15013;

        /// <summary>
        /// The identifier for the AnalogInputType_PowerStatus Variable.
        /// </summary>
        public const uint AnalogInputType_PowerStatus = 15014;

        /// <summary>
        /// The identifier for the AnalogInputType_PowerFactor Variable.
        /// </summary>
        public const uint AnalogInputType_PowerFactor = 15015;

        /// <summary>
        /// The identifier for the AnalogInputType_Status Variable.
        /// </summary>
        public const uint AnalogInputType_Status = 15016;

        /// <summary>
        /// The identifier for the AnalogOutputType_Input Variable.
        /// </summary>
        public const uint AnalogOutputType_Input = 15018;

        /// <summary>
        /// The identifier for the DigitalType_Value Variable.
        /// </summary>
        public const uint DigitalType_Value = 15020;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output = 15043;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere = 15044;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus = 15045;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt = 15046;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus = 15047;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency = 15048;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power = 15049;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus = 15050;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor = 15051;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status = 15052;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output = 15083;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere = 15084;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus = 15085;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt = 15086;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus = 15087;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency = 15088;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power = 15089;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus = 15090;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor = 15091;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status = 15092;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StartButton_Value Variable.
        /// </summary>
        public const uint Plant1_System1_OperationButton_StartButton_Value = 15095;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StopButton_Value Variable.
        /// </summary>
        public const uint Plant1_System1_OperationButton_StopButton_Value = 15097;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public const uint Plant1_System1_OperationButton_ResetButton_Value = 15099;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ModeButton_Value Variable.
        /// </summary>
        public const uint Plant1_System1_OperationButton_ModeButton_Value = 15101;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_SetPoint Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_SetPoint = 15103;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kp Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Kp = 15104;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Ki Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Ki = 15105;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kd Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Kd = 15106;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1 = new ExpandedNodeId(ThesisServer.Objects.Plant1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM1200, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM2100, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StartButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_StartButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton_StartButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StopButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_StopButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton_StopButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ResetButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_ResetButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton_ResetButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ModeButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_ModeButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton_ModeButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_SpeedController, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType = new ExpandedNodeId(ThesisServer.ObjectTypes.GenericControllerType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogInputType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogOutputType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType = new ExpandedNodeId(ThesisServer.ObjectTypes.DigitalType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(ThesisServer.ObjectTypes.ValveType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogSensorType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ButtonType = new ExpandedNodeId(ThesisServer.ObjectTypes.ButtonType, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_SetPoint = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_SetPoint, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kp = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Kp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Ki = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Ki, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kd = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Kd, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Output = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Ampere = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Volt = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Frequency = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Power = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Status = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType_Input = new ExpandedNodeId(ThesisServer.Variables.AnalogOutputType_Input, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Value = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StartButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_StartButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationButton_StartButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StopButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_StopButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationButton_StopButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_ResetButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationButton_ResetButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ModeButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_ModeButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationButton_ModeButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_SetPoint = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_SetPoint, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Kp = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Kp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Ki = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Ki, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Kd = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Kd, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Ampere component.
        /// </summary>
        public const string Ampere = "Ampere";

        /// <summary>
        /// The BrowseName for the AmpereStatus component.
        /// </summary>
        public const string AmpereStatus = "AmpereStatus";

        /// <summary>
        /// The BrowseName for the AnalogInputType component.
        /// </summary>
        public const string AnalogInputType = "AnalogInputType";

        /// <summary>
        /// The BrowseName for the AnalogOutputType component.
        /// </summary>
        public const string AnalogOutputType = "AnalogOutputType";

        /// <summary>
        /// The BrowseName for the AnalogSensorType component.
        /// </summary>
        public const string AnalogSensorType = "AnalogSensorType";

        /// <summary>
        /// The BrowseName for the ButtonType component.
        /// </summary>
        public const string ButtonType = "ButtonType";

        /// <summary>
        /// The BrowseName for the DigitalType component.
        /// </summary>
        public const string DigitalType = "DigitalType";

        /// <summary>
        /// The BrowseName for the Frequency component.
        /// </summary>
        public const string Frequency = "Frequency";

        /// <summary>
        /// The BrowseName for the GenericControllerType component.
        /// </summary>
        public const string GenericControllerType = "GenericControllerType";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the Kd component.
        /// </summary>
        public const string Kd = "Kd";

        /// <summary>
        /// The BrowseName for the Ki component.
        /// </summary>
        public const string Ki = "Ki";

        /// <summary>
        /// The BrowseName for the Kp component.
        /// </summary>
        public const string Kp = "Kp";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the Plant1 component.
        /// </summary>
        public const string Plant1 = "Plant 1";

        /// <summary>
        /// The BrowseName for the Power component.
        /// </summary>
        public const string Power = "Power";

        /// <summary>
        /// The BrowseName for the PowerFactor component.
        /// </summary>
        public const string PowerFactor = "PowerFactor";

        /// <summary>
        /// The BrowseName for the PowerStatus component.
        /// </summary>
        public const string PowerStatus = "PowerStatus";

        /// <summary>
        /// The BrowseName for the SetPoint component.
        /// </summary>
        public const string SetPoint = "SetPoint";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// The BrowseName for the System1 component.
        /// </summary>
        public const string System1 = "Tank 1";

        /// <summary>
        /// The BrowseName for the Value component.
        /// </summary>
        public const string Value = "Value";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";

        /// <summary>
        /// The BrowseName for the Volt component.
        /// </summary>
        public const string Volt = "Volt";

        /// <summary>
        /// The BrowseName for the VoltStatus component.
        /// </summary>
        public const string VoltStatus = "VoltStatus";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the ThesisServer namespace (.NET code namespace is 'ThesisServer').
        /// </summary>
        public const string ThesisServer = "http://opcfoundation.org/ThesisServer";
    }
    #endregion

    #region GenericControllerState Class
    #if (!OPCUA_EXCLUDE_GenericControllerState)
    /// <summary>
    /// Stores an instance of the GenericControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericControllerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.GenericControllerType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAd" +
           "AAAAR2VuZXJpY0NvbnRyb2xsZXJUeXBlSW5zdGFuY2UBAZk6AQGZOpk6AAD/////BAAAADVgiQoCAAAA" +
           "AQAIAAAAU2V0UG9pbnQBAZo6AwAAAAAQAAAAU2V0UG9pbnQ6IERvdWJsZQAuAESaOgAAAAv/////AwP/" +
           "////AAAAADVgiQoCAAAAAQACAAAAS3ABAZs6AwAAAAAKAAAAS3A6IERvdWJsZQAuAESbOgAAAAv/////" +
           "AwP/////AAAAADVgiQoCAAAAAQACAAAAS2kBAZw6AwAAAAAKAAAAS2k6IERvdWJsZQAuAEScOgAAAAv/" +
           "////AwP/////AAAAADVgiQoCAAAAAQACAAAAS2QBAZ06AwAAAAAKAAAAS2Q6IERvdWJsZQAuAESdOgAA" +
           "AAv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<double> SetPoint
        {
            get
            {
                return m_setPoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setPoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setPoint = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Kp
        {
            get
            {
                return m_kp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kp = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Ki
        {
            get
            {
                return m_ki;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ki, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ki = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Kd
        {
            get
            {
                return m_kd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kd = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_setPoint != null)
            {
                children.Add(m_setPoint);
            }

            if (m_kp != null)
            {
                children.Add(m_kp);
            }

            if (m_ki != null)
            {
                children.Add(m_ki);
            }

            if (m_kd != null)
            {
                children.Add(m_kd);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.SetPoint:
                {
                    if (createOrReplace)
                    {
                        if (SetPoint == null)
                        {
                            if (replacement == null)
                            {
                                SetPoint = new PropertyState<double>(this);
                            }
                            else
                            {
                                SetPoint = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SetPoint;
                    break;
                }

                case ThesisServer.BrowseNames.Kp:
                {
                    if (createOrReplace)
                    {
                        if (Kp == null)
                        {
                            if (replacement == null)
                            {
                                Kp = new PropertyState<double>(this);
                            }
                            else
                            {
                                Kp = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Kp;
                    break;
                }

                case ThesisServer.BrowseNames.Ki:
                {
                    if (createOrReplace)
                    {
                        if (Ki == null)
                        {
                            if (replacement == null)
                            {
                                Ki = new PropertyState<double>(this);
                            }
                            else
                            {
                                Ki = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Ki;
                    break;
                }

                case ThesisServer.BrowseNames.Kd:
                {
                    if (createOrReplace)
                    {
                        if (Kd == null)
                        {
                            if (replacement == null)
                            {
                                Kd = new PropertyState<double>(this);
                            }
                            else
                            {
                                Kd = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Kd;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<double> m_setPoint;
        private PropertyState<double> m_kp;
        private PropertyState<double> m_ki;
        private PropertyState<double> m_kd;
        #endregion
    }
    #endif
    #endregion

    #region AnalogInputState Class
    #if (!OPCUA_EXCLUDE_AnalogInputState)
    /// <summary>
    /// Stores an instance of the AnalogInputType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogInputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogInputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogInputType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAX" +
           "AAAAQW5hbG9nSW5wdXRUeXBlSW5zdGFuY2UBAZ46AQGeOp46AAD/////CgAAADVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQGfOgMAAAAADgAAAE91dHB1dDogRG91YmxlAC8AP586AAAAC/////8DA/////8AAAAANWCJ" +
           "CgIAAAABAAYAAABBbXBlcmUBAaA6AwAAAAAOAAAAQW1wZXJlOiBEb3VibGUALwA/oDoAAAAL/////wMD" +
           "/////wAAAAA1YIkKAgAAAAEADAAAAEFtcGVyZVN0YXR1cwEBoToDAAAAABUAAABBbXBlcmUgc3RhdHVz" +
           "OiBzdHJpbmcALwA/oToAAAAM/////wMD/////wAAAAA1YIkKAgAAAAEABAAAAFZvbHQBAaI6AwAAAAAM" +
           "AAAAVm9sdDogRG91YmxlAC8AP6I6AAAAC/////8DA/////8AAAAANWCJCgIAAAABAAoAAABWb2x0U3Rh" +
           "dHVzAQGjOgMAAAAAEgAAAFZvbHRTdGF0dXM6IHN0cmluZwAvAD+jOgAAAAz/////AwP/////AAAAADVg" +
           "iQoCAAAAAQAJAAAARnJlcXVlbmN5AQGkOgMAAAAAFAAAAEZyZXF1ZW5jeV9IejogRG91YmxlAC8AP6Q6" +
           "AAAAC/////8DA/////8AAAAANWCJCgIAAAABAAUAAABQb3dlcgEBpToDAAAAAA0AAABQb3dlcjogRG91" +
           "YmxlAC8AP6U6AAAAC/////8DA/////8AAAAANWCJCgIAAAABAAsAAABQb3dlclN0YXR1cwEBpjoDAAAA" +
           "ABMAAABQb3dlclN0YXR1czogc3RyaW5nAC8AP6Y6AAAADP////8DA/////8AAAAANWCJCgIAAAABAAsA" +
           "AABQb3dlckZhY3RvcgEBpzoDAAAAABMAAABQb3dlckZhY3RvcjogRG91YmxlAC8AP6c6AAAAC/////8D" +
           "A/////8AAAAANWCJCgIAAAABAAYAAABTdGF0dXMBAag6AwAAAAAPAAAAU3RhdHVzOiBCb29sZWFuAC8A" +
           "P6g6AAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Ampere
        {
            get
            {
                return m_ampere;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ampere, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ampere = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> AmpereStatus
        {
            get
            {
                return m_ampereStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ampereStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ampereStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Volt
        {
            get
            {
                return m_volt;
            }

            set
            {
                if (!Object.ReferenceEquals(m_volt, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_volt = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> VoltStatus
        {
            get
            {
                return m_voltStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_voltStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_voltStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Frequency
        {
            get
            {
                return m_frequency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_frequency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_frequency = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Power
        {
            get
            {
                return m_power;
            }

            set
            {
                if (!Object.ReferenceEquals(m_power, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_power = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> PowerStatus
        {
            get
            {
                return m_powerStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> PowerFactor
        {
            get
            {
                return m_powerFactor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerFactor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerFactor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_ampere != null)
            {
                children.Add(m_ampere);
            }

            if (m_ampereStatus != null)
            {
                children.Add(m_ampereStatus);
            }

            if (m_volt != null)
            {
                children.Add(m_volt);
            }

            if (m_voltStatus != null)
            {
                children.Add(m_voltStatus);
            }

            if (m_frequency != null)
            {
                children.Add(m_frequency);
            }

            if (m_power != null)
            {
                children.Add(m_power);
            }

            if (m_powerStatus != null)
            {
                children.Add(m_powerStatus);
            }

            if (m_powerFactor != null)
            {
                children.Add(m_powerFactor);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Output = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case ThesisServer.BrowseNames.Ampere:
                {
                    if (createOrReplace)
                    {
                        if (Ampere == null)
                        {
                            if (replacement == null)
                            {
                                Ampere = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Ampere = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Ampere;
                    break;
                }

                case ThesisServer.BrowseNames.AmpereStatus:
                {
                    if (createOrReplace)
                    {
                        if (AmpereStatus == null)
                        {
                            if (replacement == null)
                            {
                                AmpereStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                AmpereStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = AmpereStatus;
                    break;
                }

                case ThesisServer.BrowseNames.Volt:
                {
                    if (createOrReplace)
                    {
                        if (Volt == null)
                        {
                            if (replacement == null)
                            {
                                Volt = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Volt = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Volt;
                    break;
                }

                case ThesisServer.BrowseNames.VoltStatus:
                {
                    if (createOrReplace)
                    {
                        if (VoltStatus == null)
                        {
                            if (replacement == null)
                            {
                                VoltStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                VoltStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = VoltStatus;
                    break;
                }

                case ThesisServer.BrowseNames.Frequency:
                {
                    if (createOrReplace)
                    {
                        if (Frequency == null)
                        {
                            if (replacement == null)
                            {
                                Frequency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Frequency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Frequency;
                    break;
                }

                case ThesisServer.BrowseNames.Power:
                {
                    if (createOrReplace)
                    {
                        if (Power == null)
                        {
                            if (replacement == null)
                            {
                                Power = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Power = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Power;
                    break;
                }

                case ThesisServer.BrowseNames.PowerStatus:
                {
                    if (createOrReplace)
                    {
                        if (PowerStatus == null)
                        {
                            if (replacement == null)
                            {
                                PowerStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                PowerStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = PowerStatus;
                    break;
                }

                case ThesisServer.BrowseNames.PowerFactor:
                {
                    if (createOrReplace)
                    {
                        if (PowerFactor == null)
                        {
                            if (replacement == null)
                            {
                                PowerFactor = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                PowerFactor = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = PowerFactor;
                    break;
                }

                case ThesisServer.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Status = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_output;
        private BaseDataVariableState<double> m_ampere;
        private BaseDataVariableState<string> m_ampereStatus;
        private BaseDataVariableState<double> m_volt;
        private BaseDataVariableState<string> m_voltStatus;
        private BaseDataVariableState<double> m_frequency;
        private BaseDataVariableState<double> m_power;
        private BaseDataVariableState<string> m_powerStatus;
        private BaseDataVariableState<double> m_powerFactor;
        private BaseDataVariableState<bool> m_status;
        #endregion
    }
    #endif
    #endregion

    #region AnalogOutputState Class
    #if (!OPCUA_EXCLUDE_AnalogOutputState)
    /// <summary>
    /// Stores an instance of the AnalogOutputType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogOutputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogOutputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogOutputType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAY" +
           "AAAAQW5hbG9nT3V0cHV0VHlwZUluc3RhbmNlAQGpOgEBqTqpOgAA/////wEAAAA1YIkKAgAAAAEABQAA" +
           "AElucHV0AQGqOgMAAAAADQAAAElucHV0OiBEb3VibGUALwA/qjoAAAAL/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Input = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_input;
        #endregion
    }
    #endif
    #endregion

    #region DigitalState Class
    #if (!OPCUA_EXCLUDE_DigitalState)
    /// <summary>
    /// Stores an instance of the DigitalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DigitalState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DigitalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.DigitalType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAT" +
           "AAAARGlnaXRhbFR5cGVJbnN0YW5jZQEBqzoBAas6qzoAAP////8BAAAANWCJCgIAAAABAAUAAABWYWx1" +
           "ZQEBrDoDAAAAAA4AAABWYWx1ZTogQm9vbGVhbgAvAD+sOgAAAAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (!Object.ReferenceEquals(m_value, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_value = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_value != null)
            {
                children.Add(m_value);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Value:
                {
                    if (createOrReplace)
                    {
                        if (Value == null)
                        {
                            if (replacement == null)
                            {
                                Value = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Value = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Value;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_value;
        #endregion
    }
    #endif
    #endregion

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <summary>
    /// Stores an instance of the ValveType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : AnalogOutputState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.ValveType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAR" +
           "AAAAVmFsdmVUeXBlSW5zdGFuY2UBAa06AQGtOq06AAD/////AQAAADVgiQoCAAAAAQAFAAAASW5wdXQB" +
           "Aa46AwAAAAANAAAASW5wdXQ6IERvdWJsZQAvAD+uOgAAAAv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AnalogSensorState Class
    #if (!OPCUA_EXCLUDE_AnalogSensorState)
    /// <summary>
    /// Stores an instance of the AnalogSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorState : AnalogInputState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogSensorType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAY" +
           "AAAAQW5hbG9nU2Vuc29yVHlwZUluc3RhbmNlAQGvOgEBrzqvOgAA/////woAAAA1YIkKAgAAAAEABgAA" +
           "AE91dHB1dAEBsDoDAAAAAA4AAABPdXRwdXQ6IERvdWJsZQAvAD+wOgAAAAv/////AwP/////AAAAADVg" +
           "iQoCAAAAAQAGAAAAQW1wZXJlAQGxOgMAAAAADgAAAEFtcGVyZTogRG91YmxlAC8AP7E6AAAAC/////8D" +
           "A/////8AAAAANWCJCgIAAAABAAwAAABBbXBlcmVTdGF0dXMBAbI6AwAAAAAVAAAAQW1wZXJlIHN0YXR1" +
           "czogc3RyaW5nAC8AP7I6AAAADP////8DA/////8AAAAANWCJCgIAAAABAAQAAABWb2x0AQGzOgMAAAAA" +
           "DAAAAFZvbHQ6IERvdWJsZQAvAD+zOgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQAKAAAAVm9sdFN0" +
           "YXR1cwEBtDoDAAAAABIAAABWb2x0U3RhdHVzOiBzdHJpbmcALwA/tDoAAAAM/////wMD/////wAAAAA1" +
           "YIkKAgAAAAEACQAAAEZyZXF1ZW5jeQEBtToDAAAAABQAAABGcmVxdWVuY3lfSHo6IERvdWJsZQAvAD+1" +
           "OgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQAFAAAAUG93ZXIBAbY6AwAAAAANAAAAUG93ZXI6IERv" +
           "dWJsZQAvAD+2OgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQALAAAAUG93ZXJTdGF0dXMBAbc6AwAA" +
           "AAATAAAAUG93ZXJTdGF0dXM6IHN0cmluZwAvAD+3OgAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAL" +
           "AAAAUG93ZXJGYWN0b3IBAbg6AwAAAAATAAAAUG93ZXJGYWN0b3I6IERvdWJsZQAvAD+4OgAAAAv/////" +
           "AwP/////AAAAADVgiQoCAAAAAQAGAAAAU3RhdHVzAQG5OgMAAAAADwAAAFN0YXR1czogQm9vbGVhbgAv" +
           "AD+5OgAAAAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ButtonState Class
    #if (!OPCUA_EXCLUDE_ButtonState)
    /// <summary>
    /// Stores an instance of the ButtonType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ButtonState : DigitalState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ButtonState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.ButtonType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAS" +
           "AAAAQnV0dG9uVHlwZUluc3RhbmNlAQG6OgEBujq6OgAA/////wEAAAA1YIkKAgAAAAEABQAAAFZhbHVl" +
           "AQG7OgMAAAAADgAAAFZhbHVlOiBCb29sZWFuAC8AP7s6AAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}