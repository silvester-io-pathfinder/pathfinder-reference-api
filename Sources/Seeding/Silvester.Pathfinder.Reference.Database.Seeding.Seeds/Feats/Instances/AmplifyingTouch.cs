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
    public class AmplifyingTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("751ca3c5-287f-4133-beaf-a5b2080091ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Amplifying Touch",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4c4f0e8-4f86-4004-ba7b-ce18e0c403e6"), Type = TextBlockType.Text, Text = $"Your healing energies empower attacks. An ally that recovers Hit Points from your {ToMarkdownLink<Models.Entities.Spell>("lay on hands", Spells.Instances.LayOnHands.ID)} gains a +1 status bonus to their attack rolls and deals 1 additional good damage on all their {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} until the end of their next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("7bb73768-6d6f-4ee5-8a82-ada302389ff9"), Spells.Instances.LayOnHands.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e8852479-518f-4f91-a23b-9d1115cad7d0"), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5103f2b3-e458-49f6-9797-4bac40b8bb46"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
