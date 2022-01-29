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
    public class UnleashSelfDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("36f7507d-67f6-4ec6-9e40-960b7e8b4d16");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Self-Defense",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38c7d41b-6c65-47bb-8361-ae5fe683722f"), Type = TextBlockType.Text, Text = $"The conflict-averse aspects of your personality float calmly to the surface, causing your mind to subconsciously deflect incoming attacks, though this comes at the cost of reduced fatal intent behind your spells." };
            yield return new TextBlock { Id = Guid.Parse("7edce679-f66d-4c72-813b-1a0efb1f985e"), Type = TextBlockType.Text, Text = $"~ Benefit: While this psyche is Unleashed, you gain a +1 status bonus to your AC and to one saving throw of your choice, decided when you Unleash your psyche. All of your spells that don't have the {ToMarkdownLink<Models.Entities.Trait>("death", Traits.Instances.Death.ID)} trait gain the {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} trait." };
            yield return new TextBlock { Id = Guid.Parse("5d8b040d-cb44-4c0f-a587-0c1fda23f5de"), Type = TextBlockType.Text, Text = $"~ Drawback: The pacifist influence on your mind makes it difficult for your spells to strike a killing blow. You take a penalty to spell damage rolls equal to the level of the spell, and you take a –1 penalty to spell attack rolls and DC of any spell that deals damage or otherwise affects the target's health or Hit Points (including those that apply the drained condition, disease or poison the target, or kill the target)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbddf6cd-6381-4baa-b2e6-9ba53d6aa1b7"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
