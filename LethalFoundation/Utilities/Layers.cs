using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LethalFoundation
{
    public static class Layers
    {
        public static LayerMask Default { get; private set; } = Get(LayerNames.Default);
        public static LayerMask TransparentFX { get; private set; } = Get(LayerNames.TransparentFX);
        public static LayerMask IgnoreRaycast { get; private set; } = Get(LayerNames.IgnoreRaycast);
        public static LayerMask Player { get; private set; } = Get(LayerNames.Player);
        public static LayerMask Water { get; private set; } = Get(LayerNames.Water);
        public static LayerMask UI { get; private set; } = Get(LayerNames.UI);
        public static LayerMask Props { get; private set; } = Get(LayerNames.Props);
        public static LayerMask HelmetVisor { get; private set; } = Get(LayerNames.HelmetVisor);
        public static LayerMask Room { get; private set; } = Get(LayerNames.Room);
        public static LayerMask InteractableObject { get; private set; } = Get(LayerNames.InteractableObject);
        public static LayerMask Foliage { get; private set; } = Get(LayerNames.Foliage);
        public static LayerMask Colliders { get; private set; } = Get(LayerNames.Colliders);
        public static LayerMask PhysicsObject { get; private set; } = Get(LayerNames.PhysicsObject);
        public static LayerMask Triggers { get; private set; } = Get(LayerNames.Triggers);
        public static LayerMask MapRadar { get; private set; } = Get(LayerNames.MapRadar);
        public static LayerMask NavigationSurface { get; private set; } = Get(LayerNames.NavigationSurface);
        public static LayerMask MoldSpore { get; private set; } = Get(LayerNames.MoldSpore);
        public static LayerMask Anomaly { get; private set; } = Get(LayerNames.Anomaly);
        public static LayerMask LineOfSight { get; private set; } = Get(LayerNames.LineOfSight);
        public static LayerMask Enemies { get; private set; } = Get(LayerNames.Enemies);
        public static LayerMask PlayerRagdoll { get; private set; } = Get(LayerNames.PlayerRagdoll);
        public static LayerMask MapHazards { get; private set; } = Get(LayerNames.MapHazards);
        public static LayerMask ScanNode { get; private set; } = Get(LayerNames.ScanNode);
        public static LayerMask EnemiesNotRendered { get; private set; } = Get(LayerNames.EnemiesNotRendered);
        public static LayerMask MiscLevelGeometry { get; private set; } = Get(LayerNames.MiscLevelGeometry);
        public static LayerMask Terrain { get; private set; } = Get(LayerNames.Terrain);
        public static LayerMask PlaceableShipObjects { get; private set; } = Get(LayerNames.PlaceableShipObjects);
        public static LayerMask PlacementBlocker { get; private set; } = Get(LayerNames.PlacementBlocker);
        public static LayerMask Railing { get; private set; } = Get(LayerNames.Railing);
        public static LayerMask DecalStickableSurface { get; private set; } = Get(LayerNames.DecalStickableSurface);
        public static LayerMask Vehicle { get; private set; } = Get(LayerNames.Vehicle);

        public static LayerMask Combine(this LayerMask mask, params LayerMask[] layers) => Combine(mask, layers);
        public static LayerMask Combine(params LayerMask[] layers)
        {
            if (layers == null || layers.Length == 0) return (default);
            LayerMask result = layers[0];
            for (int i = 1; i < layers.Length; i++)
                result = result | layers[i];
            return (result);
        }

        private static LayerMask Get(string name) => LayerMask.GetMask(name); //Just to shorten this mess.
    }
}
