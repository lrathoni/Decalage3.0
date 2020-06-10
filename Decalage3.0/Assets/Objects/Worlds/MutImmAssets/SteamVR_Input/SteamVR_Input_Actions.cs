//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Vector2 p_character_Controls_MoveHorizontal;
        
        private static SteamVR_Action_Single p_character_Controls_Jump;
        
        public static SteamVR_Action_Vector2 character_Controls_MoveHorizontal
        {
            get
            {
                return SteamVR_Actions.p_character_Controls_MoveHorizontal.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Single character_Controls_Jump
        {
            get
            {
                return SteamVR_Actions.p_character_Controls_Jump.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.character_Controls_MoveHorizontal,
                    SteamVR_Actions.character_Controls_Jump};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.character_Controls_MoveHorizontal,
                    SteamVR_Actions.character_Controls_Jump};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[0];
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[0];
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[0];
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[0];
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[] {
                    SteamVR_Actions.character_Controls_Jump};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[] {
                    SteamVR_Actions.character_Controls_MoveHorizontal};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[0];
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.character_Controls_MoveHorizontal,
                    SteamVR_Actions.character_Controls_Jump};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_character_Controls_MoveHorizontal = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/Character_Controls/in/MoveHorizontal")));
            SteamVR_Actions.p_character_Controls_Jump = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/Character_Controls/in/Jump")));
        }
    }
}