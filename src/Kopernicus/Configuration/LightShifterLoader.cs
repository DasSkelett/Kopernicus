/**
 * Kopernicus Planetary System Modifier
 * ------------------------------------------------------------- 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 * 
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright 2011-2017 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using Kopernicus.Components;
using System;
using UnityEngine;

namespace Kopernicus
{
    namespace Configuration
    {
        [RequireConfigType(ConfigType.Node)]
        public class LightShifterLoader : BaseLoader, IParserEventSubscriber
        {
            /// <summary>
            /// LightShifter we're modifying
            /// </summary>
            public LightShifter lsc { get; set; }

            // The sunflare for the star
            [ParserTarget("sunFlare")]
            public AssetParser<Flare> sunFlare
            {
                get { return lsc.sunFlare; }
                set { lsc.sunFlare = value; }
            }

            // sunlightColor
            [ParserTarget("sunlightColor")]
            public ColorParser sunlightColor
            {
                get { return lsc.sunlightColor; }
                set { lsc.sunlightColor = value; }
            }

            // sunlightIntensity
            [ParserTarget("sunlightIntensity")]
            public NumericParser<Single> sunlightIntensity
            {
                set
                {
                    lsc.intensityCurve = new FloatCurve(new Keyframe[]
                    {
                        new Keyframe(0, value),
                        new Keyframe(1, value)
                    });
                }
            }

            // sunlightShadowStrength
            [ParserTarget("sunlightShadowStrength")]
            public NumericParser<Single> sunlightShadowStrength
            {
                get { return lsc.sunlightShadowStrength; }
                set { lsc.sunlightShadowStrength = value; }
            }

            // scaledSunlightColor
            [ParserTarget("scaledSunlightColor")]
            public ColorParser scaledSunlightColor
            {
                get { return lsc.scaledSunlightColor; }
                set { lsc.scaledSunlightColor = value; }
            }

            // scaledSunlightIntensity
            [ParserTarget("scaledSunlightIntensity")]
            public NumericParser<Single> scaledSunlightIntensity
            {
                set
                {
                    lsc.scaledIntensityCurve = new FloatCurve(new Keyframe[]
                    {
                        new Keyframe(0, value),
                        new Keyframe(1, value)
                    });
                }
            }

            // IVASunColor
            [ParserTarget("IVASunColor")]
            public ColorParser IVASunColor
            {
                get { return lsc.IVASunColor; }
                set { lsc.IVASunColor = value; }
            }

            // IVASunIntensity
            [ParserTarget("IVASunIntensity")]
            public NumericParser<Single> IVASunIntensity
            {
                set
                {
                    lsc.ivaIntensityCurve = new FloatCurve(new Keyframe[]
                    {
                        new Keyframe(0, value),
                        new Keyframe(1, value)
                    });
                }
            }

            // ambientLightColor
            [ParserTarget("ambientLightColor")]
            public ColorParser ambientLightColor
            {
                get { return lsc.ambientLightColor; }
                set { lsc.ambientLightColor = value; }
            }

            // Set the color that the star emits
            [ParserTarget("sunLensFlareColor")]
            public ColorParser sunLensFlareColor
            {
                get { return lsc.sunLensFlareColor; }
                set { lsc.sunLensFlareColor = value; }
            }

            // givesOffLight
            [ParserTarget("givesOffLight")]
            public NumericParser<Boolean> givesOffLight
            {
                get { return lsc.givesOffLight; }
                set { lsc.givesOffLight = value; }
            }

            // sunAU
            [ParserTarget("sunAU")]
            public NumericParser<Double> sunAU
            {
                get { return lsc.AU; }
                set { lsc.AU = value; }
            }

            // brightnessCurve
            [ParserTarget("brightnessCurve")]
            public FloatCurveParser brightnessCurve
            {
                get { return lsc.brightnessCurve; }
                set { lsc.brightnessCurve = value; }
            }

            // sunAU
            [ParserTarget("luminosity")]
            public NumericParser<Double> luminosity
            {
                get { return lsc.solarLuminosity; }
                set { lsc.solarLuminosity = value; }
            }

            // sunAU
            [ParserTarget("insolation")]
            public NumericParser<Double> insolation
            {
                get { return lsc.solarInsolation; }
                set { lsc.solarInsolation = value; }
            }

            // sunAU
            [ParserTarget("radiationFactor")]
            public NumericParser<Double> radiation
            {
                get { return lsc.radiationFactor; }
                set { lsc.radiationFactor = value; }
            }

            // intensityCurve
            [ParserTarget("IntensityCurve")]
            public FloatCurveParser intensityCurve
            {
                get { return lsc.intensityCurve; }
                set { lsc.intensityCurve = value; }
            }

            // scaledIntensityCurve
            [ParserTarget("ScaledIntensityCurve")]
            public FloatCurveParser scaledIntensityCurve
            {
                get { return lsc.scaledIntensityCurve; }
                set { lsc.scaledIntensityCurve = value; }
            }

            // intensityCurve
            [ParserTarget("IVAIntensityCurve")]
            public FloatCurveParser ivaIntensityCurve
            {
                get { return lsc.ivaIntensityCurve; }
                set { lsc.ivaIntensityCurve = value; }
            }

            // Parser apply event
            void IParserEventSubscriber.Apply(ConfigNode node)
            {
                Events.OnLightShifterLoaderApply.Fire(this, node);
            }

            // Parser post apply event
            void IParserEventSubscriber.PostApply(ConfigNode node)
            {
                Events.OnLightShifterLoaderPostApply.Fire(this, node);
            }

            /// <summary>
            /// Creates a new LightShifter Loader from the Injector context.
            /// </summary>
            public LightShifterLoader()
            {
                // Is this the parser context?
                if (generatedBody == null)
                    throw new InvalidOperationException("Must be executed in Injector context.");

                // Store values
                lsc = LightShifter.prefab;
                lsc.transform.parent = generatedBody.scaledVersion.transform;
                lsc.name = generatedBody.name;
            }

            /// <summary>
            /// Creates a new LightShifter Loader from a spawned CelestialBody.
            /// </summary>
            public LightShifterLoader(CelestialBody body)
            {
                // Is this a spawned body?
                if (body?.scaledBody == null)
                    throw new InvalidOperationException("The body must be already spawned by the PSystemManager.");

                // Store values
                lsc = body.GetComponentInChildren<LightShifter>();
            }

            /// <summary>
            /// Creates a new LightShifter Loader from a custom PSystemBody.
            /// </summary>
            public LightShifterLoader(PSystemBody body)
            {
                // Set generatedBody
                if (body == null)
                    throw new InvalidOperationException("The body cannot be null.");
                generatedBody = body;

                // Store values
                lsc = LightShifter.prefab;
                lsc.transform.parent = generatedBody.scaledVersion.transform;
                lsc.name = generatedBody.name;
            }
        }

    }
}