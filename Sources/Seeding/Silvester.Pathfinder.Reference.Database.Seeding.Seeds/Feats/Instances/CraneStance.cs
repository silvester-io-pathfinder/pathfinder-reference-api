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
    public class CraneStance : Template
    {
        public static readonly Guid ID = Guid.Parse("3a5d62ea-ca37-4ca8-bccc-4d48f6d4d437");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crane Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("011ea4a0-05f3-4c27-b172-9b2133f1e71c"), Type = TextBlockType.Text, Text = $"You enter the stance of a crane, holding your arms in an imitation of a crane's wings and using flowing, defensive motions. You gain a +1 circumstance bonus to AC, but the only {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you can make are crane wing attacks. These deal 1d6 bludgeoning damage; are in the brawling group; and have the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits." };
            yield return new TextBlock { Id = Guid.Parse("8c3ad11f-8fef-4f15-96ed-5dc252ff6cd3"), Type = TextBlockType.Text, Text = $"While in Crane Stance, reduce the DC for {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} by 5, and when you {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)}, you can move an additional 5 feet horizontally or 2 feet vertically." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6def3c0d-5231-4f14-8f91-405bf92b87bf"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab884236-d312-4781-a41b-8828eee220b3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
