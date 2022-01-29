using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrixDefender : Template
    {
        public static readonly Guid ID = Guid.Parse("c51be8e5-6a62-46b1-bb99-6bd14ca3c534");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strix Defender",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab8b7307-82ce-4181-9ed7-8df74936f7e9"), Type = TextBlockType.Text, Text = $"Your ancestral feud with humans gives you experience dealing with vicious foes, and your vengeance knows no bounds. You gain a +1 circumstance bonus to Intimidation, Perception, and Survival checks against humans, as well as on damage rolls against humans with weapons and unarmed attacks. However, your hatred of humans is immediately obvious, giving you a -2 circumstance penalty to Diplomacy checks against them and usually starting their attitude one step worse towards you." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39505c78-6ac6-4b9a-a3ee-8abfd01cc1df"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
