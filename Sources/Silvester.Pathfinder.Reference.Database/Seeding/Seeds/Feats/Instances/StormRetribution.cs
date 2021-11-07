using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StormRetribution : Template
    {
        public static readonly Guid ID = Guid.Parse("2ae40f6e-38e1-4dae-adf8-17f7fcf4ee1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Storm Retribution",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An opponent adjacent to you critically hits you with a melee weapon or melee unarmed attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34570f77-7842-4f1c-83c8-1c51f211990b"), Type = TextBlockType.Text, Text = "You lash out, directing a burst of storming fury toward a creature that has harmed you. You cast (Spell: tempest surge) on the triggering opponent and push that creature, moving it 5 feet away from you if it fails its Reflex save, or 10 feet if it critically fails. This movement is forced movement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("b2169ee4-896f-4468-9cfe-569d1612a2e4"), DruidicOrders.Instances.Storm.ID);
            builder.HaveSpecificSpell(Guid.Parse("7905403e-1753-4027-bb9a-d132ed82ab5c"), Spells.Instances.TempestSurge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("467fd986-4836-40c5-b87f-5cf393fe0d5e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
