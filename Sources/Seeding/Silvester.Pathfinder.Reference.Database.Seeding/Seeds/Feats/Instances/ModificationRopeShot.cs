using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationRopeShot : Template
    {
        public static readonly Guid ID = Guid.Parse("247d38ca-167d-4436-a2e4-81bdf7fcc3d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Rope Shot",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ebb8b07c-dc34-4128-9494-0660150353ee"), Type = TextBlockType.Enumeration, Text = "*Ranged Only**" };
            yield return new TextBlock { Id = Guid.Parse("e9ebff7f-b10a-4ed7-a639-76f2cf75230e"), Type = TextBlockType.Text, Text = "Your weapon can shoot projectiles that split into simple ropes or nets around your foes’ legs to trip your targets, and you can climb using the grappling hooks built into the weapon. Your weapon innovation gains the (trait: climbing) and (trait: ranged trip) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88b7254f-3536-45fc-903e-a34086cf0e2b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
