using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PurifyingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("4856223d-48ba-449e-bb62-83a126ae245b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Purifying Spell",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("666645c8-b0c5-4cb1-a9ef-f5db5d455cd7"), Type = TextBlockType.Text, Text = "You purify the water within a creature’s body to cleanse them of illness. If the next action you use is to cast (spell: heal) targeting a single living creature, you can attempt to counteract a disease or poison affecting the target, in addition to the other benefits of (spell: heal). If you do, (spell: heal) gains the (trait: water) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("db5fd808-59e3-4ef4-bb1a-1ef86948961a"), DruidicOrders.Instances.Wave.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22090b92-dd6a-435d-b71e-b27f4ce6c09a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
