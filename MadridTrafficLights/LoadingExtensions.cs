using ICities;
using UnityEngine;
using MadridTrafficLights.Utils;
using ColossalFramework;

namespace MadridTrafficLights
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public void CloneLaneProp(NetLaneProps.Prop laneProp, NetLaneProps.Prop lanePropCopy)
        {
            lanePropCopy.m_position = laneProp.m_position;
            lanePropCopy.m_angle = laneProp.m_angle;
            lanePropCopy.m_flagsForbidden = laneProp.m_flagsForbidden;
            lanePropCopy.m_flagsRequired = laneProp.m_flagsRequired;
            lanePropCopy.m_endFlagsRequired = laneProp.m_endFlagsRequired;
            lanePropCopy.m_endFlagsForbidden = laneProp.m_endFlagsForbidden;
            lanePropCopy.m_startFlagsForbidden = laneProp.m_startFlagsForbidden;
            lanePropCopy.m_startFlagsRequired = laneProp.m_startFlagsRequired;
            lanePropCopy.m_minLength = laneProp.m_minLength;
            lanePropCopy.m_probability = laneProp.m_probability;
            lanePropCopy.m_repeatDistance = laneProp.m_repeatDistance;
            lanePropCopy.m_segmentOffset = laneProp.m_segmentOffset;
            lanePropCopy.m_colorMode = laneProp.m_colorMode;
            lanePropCopy.m_cornerAngle = laneProp.m_cornerAngle;
        }
        
        public void CloneLanePropList(NetLaneProps.Prop[] oldPropList, NetLaneProps.Prop[] newPropList, int nProps)
        {
            for (int i = 0; i < nProps; i++)
            {
                newPropList[i] = oldPropList[i];
            }
        }

        public bool IsMadridRoadSmall(string name)
        {
            return (name == "1985728732.Madrid A P1+1P_Data" ||
                    name == "2008772090.Madrid AT P1+1P_Data" ||
                    name == "1997443071.Madrid B 1+1_Data" ||
                    name == "1997443071.Madrid B P1+1P_Data" ||
                    name == "1985728732.Madrid A P1P_Data" ||
                    name == "1985728732.Madrid A P2P_Data" ||
                    name == "2008772090.Madrid AT P1P_Data" ||
                    name == "2008772090.Madrid AT P2P_Data" ||
                    name == "1997443071.Madrid B 1_Data" ||
                    name == "1997443071.Madrid B 2_Data" ||
                    name == "1997443071.Madrid B 3_Data" ||
                    name == "1997443071.Madrid B P1P_Data" ||
                    name == "1997443071.Madrid B P2P_Data" ||
                    name == "1997443071.Madrid B 1+1P_Data" ||
                    name == "1997443071.Madrid B 1P_Data" ||
                    name == "1997443071.Madrid B 2P_Data" ||
                    name == "1997443071.Madrid B P1_Data");
        }

        public bool IsMadridRoadSmall12(string name)
        {
            return (name == "1985728732.Madrid A P1+2P_Data" ||
                    name == "2008772090.Madrid AT P1+2P_Data" ||
                    name == "1997443071.Madrid B 1+2_Data");
        }

        public bool IsMadridRoadSmall3(string name)
        {
            return (name == "1985728732.Madrid A P3P_Data" ||
                    name == "2008772090.Madrid AT P3P_Data" ||
                    name == "1997443071.Madrid B 3_Data" ||
                    name == "1997443071.Madrid B P3P_Data" ||
                    name == "1997443071.Madrid B 3P_Data");
        }

        public bool IsMadridRoadMedium(string name)
        {
            return (name == "1985728732.Madrid A P2+2P_Data" ||
                    name == "2008772090.Madrid AT P2+2P_Data" ||
                    name == "1997443071.Madrid B 2+2_Data" ||
                    name == "1997443071.Madrid B P2+2P_Data");
        }

        public bool IsMadridRoadMedium4(string name)
        {
            return (name == "1997443071.Madrid B 4P_Data" ||
                    name == "1985728732.Madrid A P4P_Data" ||
                    name == "1997443071.Madrid B P4P_Data" ||
                    name == "2008772090.Madrid AT P4P_Data" ||
                    name == "1997443071.Madrid B 4_Data");
        }

        public override void OnReleased()
        {
            base.OnReleased();
        }

        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);
            if (mode != LoadMode.LoadGame && mode != LoadMode.NewGame && mode != LoadMode.NewGameFromScenario)
            {
                return;
            }

            var Mb = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights M blink_Data");
            
            var P_L = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights P Left_Data");
            var P_R = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights P Right_Data");
            
            var MSP_L = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid Traffic Lights - MSP Left_Data");
            var MSP_R = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid Traffic Lights - MSP Righ_Data");

            var LMSP_L = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights LMSP Left_Data");
            var LMSP_R = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights LMSP Right_Data");

            var dLMSP_L = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights dLMSP Left_Data");
            var dLMSP_R = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights dLMSP Right_Data");
            var xLMSP_L = PrefabCollection<PropInfo>.FindLoaded("2270587845.MMadrid TrafficLights xLMSP Left_Data");
            var xLMSP_R = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights xLMSP Right_Data");

            //var MS_L = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights MS Left_Data");
            //var MS_R = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights MS Right_Data");
            //var LMS_L = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights LMS Left_Data");
            //var LMS_R = PrefabCollection<PropInfo>.FindLoaded("2270587845.Madrid TrafficLights LMS Right_Data");

            if (
                //MS_L == null ||
                //MS_R == null ||
                //LMS_L == null ||
                //LMS_R == null ||
                Mb == null ||
                P_L == null ||
                P_R == null ||
                MSP_L == null ||
                MSP_R == null ||
                LMSP_L == null ||
                LMSP_R == null
                )
            {
                return;
            }

            //int nProps = 0;
            //// loop through all segments
            //for (ushort segmentID = 0; segmentID < NetManager.MAX_SEGMENT_COUNT; ++segmentID)
            //{
            //    NetSegment segment = segmentID.ToSegment();
            //
            //    if (!segment.Info)
            //        continue;
            //
            //    // loop through both nodes of each segment
            //    foreach (bool bStartNode in new bool[] { false, true })
            //    {
            //        // if the segment+node section has crossing ban
            //        if (TMPEUTILS.HasCrossingBan(segmentID, bStartNode))
            //        {
            //            ushort nodeID = bStartNode ? segment.m_startNode : segment.m_endNode;
            //
            //            foreach (var node in segment.Info.m_nodes)
            //            {
            //                if (node.m_directConnect)
            //                    continue;
            //                var flags = nodeID.ToNode().m_flags;
            //
            //                if (nodeID.ToNode().m_flags.IsFlagSet(NetNode.Flags.Junction))
            //                {
            //                    // clone road info and change name
            //                    var road = segment.Info;
            //                    var newRoad = NetInfo.Instantiate(road);
            //                    newRoad.name += "_noCrossMadrid";
            //
            //                    foreach (var lane in newRoad.m_lanes)
            //                    {
            //                        if (lane?.m_laneProps?.m_props == null)
            //                        {
            //                            continue;
            //                        }
            //
            //                        foreach (var laneProp in lane.m_laneProps.m_props)
            //                        {
            //                            var prop = laneProp.m_finalProp;
            //                            if (prop == null)
            //                            {
            //                                continue;
            //                            }
            //                            var name = prop.name;
            //
            //                            if (name == "Traffic Light European 01" || name == "Traffic Light 01")
            //                            {
            //                                laneProp.m_finalProp = MS_L;
            //                                laneProp.m_prop = MS_L;
            //                            }
            //                        }
            //                    }
            //
            //                    //set segment road as new road
            //                    if (newRoad.GetInstanceID() != road.GetInstanceID())
            //                    {
            //
            //                    }
            //                }
            //            }
            //        } 
            //        else
            //        {
            //            
            //        }
            //    }
            //}



            var roads = Resources.FindObjectsOfTypeAll<NetInfo>();
            foreach (var road in roads)
            {
                var size = road.m_class.name;
                var roadName = road.name;
                bool isSmall = size == "Small Road";
                bool isMedium = size == "Medium Road";
                bool isLarge = size == "Large Road";
                bool hasParking = road.m_hasParkingSpaces;
                bool isOneWay = !(road.m_hasForwardVehicleLanes && road.m_hasBackwardVehicleLanes);
                bool isMadridSmall = IsMadridRoadSmall(roadName);
                bool isMadridSmall12 = IsMadridRoadSmall12(roadName);
                bool isMadridSmall3 = IsMadridRoadSmall3(roadName);
                bool isMadridMedium = IsMadridRoadMedium(roadName);
                bool isMadridMedium4 = IsMadridRoadMedium4(roadName);
                bool isMadrid = isMadridSmall || isMadridSmall12 || isMadridSmall3 || isMadridMedium || isMadridMedium4;

                if (road.m_lanes == null)
                {
                    return;
                }
                foreach (var lane in road.m_lanes)
                {
                    if (lane?.m_laneProps?.m_props == null)
                    {
                        continue;
                    }

                    foreach (var laneProp in lane.m_laneProps.m_props)
                    {
                        bool isInverted = !laneProp.m_flagsForbidden.IsFlagSet(NetLane.Flags.Inverted);
                        var absPos = lane.m_position + laneProp.m_position.x;
                        bool isJoinedJuncInvForbidden = laneProp.m_flagsForbidden.IsFlagSet(NetLane.Flags.JoinedJunctionInverted);
                        bool hasStartJunction = laneProp.m_startFlagsRequired.IsFlagSet(NetNode.Flags.Junction);
                        bool hasEndJunction = laneProp.m_endFlagsRequired.IsFlagSet(NetNode.Flags.Junction);
                        bool areStartTrafficLightsForb = laneProp.m_startFlagsForbidden.IsFlagSet(NetNode.Flags.TrafficLights);
                        bool areEndTrafficLightsForb = laneProp.m_endFlagsForbidden.IsFlagSet(NetNode.Flags.TrafficLights);

                        var prop = laneProp.m_finalProp;
                        if (prop == null)
                        {
                            continue;
                        }
                        var name = prop.name;

                        if (name == "Traffic Light European 01" || name == "Traffic Light 01")
                        {
                            laneProp.m_finalProp = MSP_L;
                            laneProp.m_prop = MSP_L;
                        }
                        if (name == "Traffic Light European 01 Mirror" || name == "Traffic Light 01 Mirror")
                        {
                            laneProp.m_finalProp = MSP_R;
                            laneProp.m_prop = MSP_R;
                        }
                        if (name == "Traffic Light European 02" || name == "Traffic Light 02")
                        {
                            if ((isMadridMedium || 
                                isMadridMedium4 || 
                                isMadridSmall12 ||
                                (roadName == "1997443071.Madrid B 3P_Data" && !isInverted))
                                && hasParking && roadName != "2008772090.Madrid AT P4P_Data" && roadName != "2008772090.Madrid AT P1+2P_Data")
                            {
                                laneProp.m_finalProp = xLMSP_R;
                                laneProp.m_prop = xLMSP_R;
                            }
                            else if (isLarge & !isMadrid)
                            {
                                laneProp.m_finalProp = dLMSP_R;
                                laneProp.m_prop = dLMSP_R;
                            }
                            else
                            {
                                laneProp.m_finalProp = LMSP_R;
                                laneProp.m_prop = LMSP_R;
                            }
                        }
                        if (name == "Traffic Light European 02 Mirror" || name == "Traffic Light 02 Mirror")
                        {
                            if ((isMadridMedium || 
                                isMadridMedium4 || 
                                isMadridSmall12 ||
                                (roadName == "1997443071.Madrid B 3P_Data" && isInverted))
                                && hasParking && roadName != "2008772090.Madrid AT P4P_Data" && roadName != "2008772090.Madrid AT P1+2P_Data")
                            {
                                laneProp.m_finalProp = xLMSP_L;
                                laneProp.m_prop = xLMSP_L;
                            }
                            else if (isLarge && !isMadrid)
                            {
                                laneProp.m_finalProp = dLMSP_L;
                                laneProp.m_prop = dLMSP_L;
                            }
                            else
                            {
                                laneProp.m_finalProp = LMSP_L;
                                laneProp.m_prop = LMSP_L;
                            }
                        }
                        if (name == "Traffic Light Pedestrian European" || name == "Traffic Light Pedestrian")
                        {
                            laneProp.m_finalProp = Mb;
                            laneProp.m_prop = Mb;

                            // Length of the prop list from this lane
                            var nProps = lane.m_laneProps.m_props.Length;

                            // Copy of the current prop (originally pedestrian tl, now Mb)
                            NetLaneProps.Prop lanePropCopy = new NetLaneProps.Prop();
                            CloneLaneProp(laneProp, lanePropCopy);
                            // Set copy to P_L
                            lanePropCopy.m_finalProp = P_L;
                            lanePropCopy.m_prop = P_L;

                            // Set prop to P_R and rotate props in the proper conditions
                            if (!isInverted)
                            {
                                if (isOneWay)
                                {
                                    laneProp.m_angle = 90;
                                    lanePropCopy.m_angle = 90;

                                    if (absPos > 0)
                                    {
                                        lanePropCopy.m_finalProp = P_R;
                                        lanePropCopy.m_prop = P_R;
                                    }
                                }
                                else // !isOneWay
                                {
                                    if (absPos > 0)
                                    {
                                        laneProp.m_angle = 90;
                                        lanePropCopy.m_angle = 90;
                                    }
                                    else
                                    {
                                        laneProp.m_angle = 270;
                                        lanePropCopy.m_angle = 270;
                                    }

                                    if (absPos > 3 || absPos < -3)
                                    {
                                        lanePropCopy.m_finalProp = P_R;
                                        lanePropCopy.m_prop = P_R;
                                    }
                                }
                            }
                            else // isInverted
                            {
                                if (isOneWay)
                                {
                                    laneProp.m_angle = 270;
                                    lanePropCopy.m_angle = 270;

                                    if (absPos < 0)
                                    {
                                        lanePropCopy.m_finalProp = P_R;
                                        lanePropCopy.m_prop = P_R;
                                    }
                                }
                                else // !isOneWay
                                {
                                    if (absPos > 0)
                                    {
                                        laneProp.m_angle = 270;
                                        lanePropCopy.m_angle = 270;
                                    }
                                    else
                                    {
                                        laneProp.m_angle = 90;
                                        lanePropCopy.m_angle = 90;
                                    }

                                    if (absPos < 3 && absPos > -3)
                                    {
                                        lanePropCopy.m_finalProp = P_R;
                                        lanePropCopy.m_prop = P_R;
                                    }
                                }
                            }

                            // Clone prop list into new one with length+1
                            var newPropList = new NetLaneProps.Prop[nProps+1];
                            CloneLanePropList(lane.m_laneProps.m_props, newPropList, nProps);
                            // Set new prop as last element of new list
                            newPropList[nProps] = lanePropCopy;
                            // Set new prop list as the actual prop list
                            lane.m_laneProps.m_props = newPropList;
                        }
                        if (isMadrid)
                        {
                            if ((!isInverted && hasStartJunction && !areStartTrafficLightsForb) ||
                                    (isInverted && hasEndJunction && !areEndTrafficLightsForb))
                            {
                                if (name == "1074496614.French Road Sign - C20a_Data")
                                {
                                    laneProp.m_probability = 0;
                                }
                                if (name == "1074496614.French Road Sign - C12_Data")
                                {
                                    laneProp.m_position.y = 0;
                                }
                            }
                        }
                        if (name == "1977954422.Overhead no left turn sign_Data")
                        {
                            laneProp.m_cornerAngle = 0.5f;
                            laneProp.m_position.y -= 0.7f;
                        }
                    }
                }
            }

        }
    }
}