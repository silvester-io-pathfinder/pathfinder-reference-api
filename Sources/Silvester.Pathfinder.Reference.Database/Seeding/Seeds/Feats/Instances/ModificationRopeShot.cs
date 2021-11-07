using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationRopeShot : Template
    {
        public static readonly Guid ID = Guid.Parse("56a87cce-498b-4de4-8007-446bc7785a1f");

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
            yield return new TextBlock { Id = Guid.Parse("d2f2bd2b-1168-4f55-9b34-edaca19840ad"), Type = TextBlockType.Enumeration, Text = "*Ranged Only**" };
            yield return new TextBlock { Id = Guid.Parse("f1778502-253c-40ca-9a53-8d8cdcafc2e5"), Type = TextBlockType.Text, Text = "Your weapon can shoot projectiles that split into simple ropes or nets around your foes’ legs to trip your targets, and you can climb using the grappling hooks built into the weapon. Your weapon innovation gains the (trait: climbing) and (trait: ranged trip) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba4cf396-2f91-4ddb-8ab5-cdecdbf2a755"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
