using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterInterpose : Template
    {
        public static readonly Guid ID = Guid.Parse("c516ff47-e98c-4c5a-93aa-623a789b9052");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Interpose",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f9456f8-b519-428f-98eb-1539e6ab1766"), Type = TextBlockType.Text, Text = "You're able to avoid hits that others could not. You can use (feat: Sacrifice Armor) to reduce any type of damage from an attack or effect requiring a Reflex save." };
            yield return new TextBlock { Id = Guid.Parse("d0943c0a-a165-4e71-9d1c-d99a5ce45225"), Type = TextBlockType.Text, Text = "When you use (feat: Sacrifice Armor) against a critical hit or a critical failure on a Reflex save that would otherwise cause you to take double damage, you take the normal amount of damage instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e4e98efe-cae2-4186-808b-4a50daf487e2"), Feats.Instances.SacrificeArmor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b645c1b9-4226-408c-96db-105f71a0c882"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
