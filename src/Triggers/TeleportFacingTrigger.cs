using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Monocle;

namespace Celeste.Mod.ProgHelper;

[CustomEntity("progHelper/teleportFacingTrigger"), Tracked]
public class TeleportFacingTrigger : Entity {
    public Facings Facing;

    public TeleportFacingTrigger(EntityData data, Vector2 offset) : base(data.Position + offset) {
        Collider = new Hitbox(data.Width, data.Height);
        Facing = data.Enum<Facings>("facing");
        Visible = Active = false;
    }
}