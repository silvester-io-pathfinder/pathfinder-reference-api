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
    public class MarkForDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("b18213d6-e25d-4eb0-9ef6-de94e0b9a2c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mark for Death",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a65e8c8a-147b-46cc-8e14-482022d000c2"), Type = TextBlockType.Text, Text = $"You designate a single creature as your mark. This lasts until the mark dies or you use Mark for Death again." };
            yield return new TextBlock { Id = Guid.Parse("29550299-62c0-4466-8425-518fc9035e6a"), Type = TextBlockType.Text, Text = $"You gain a +2 circumstance bonus to Perception checks to {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} your mark and on Deception checks to {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)} against your mark. Your {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} and {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} weapons and unarmed attacks gain the {ToMarkdownLink<Models.Entities.Trait>("backstabber", Traits.Instances.Backstabber.ID)} and {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} d6 weapon traits when you're attacking your mark. If the weapon or unarmed attack already has the {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} trait, increase the size of the deadly damage die by one step instead of giving it deadly d6." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01eedc2a-8df4-49ad-ae65-2b180e0c8fe0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
