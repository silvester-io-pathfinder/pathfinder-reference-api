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
    public class TongueTether : Template
    {
        public static readonly Guid ID = Guid.Parse("17b58bec-e56c-4440-be56-1e9b669b3c2a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tongue Tether",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31deb27b-2433-45c2-bc1f-1647f7378c77"), Type = TextBlockType.Text, Text = $"Your tongue can momentarily latch on as readily as your hands. So long as you can freely open your mouth, you do not need free hands in order to {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)}, {ToMarkdownLink<Models.Entities.Action>("Grab an Edge", Actions.Instances.GrabEdge.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}. If you have the {ToMarkdownLink<Models.Entities.Feat>("Long Tongue", Feats.Instances.LongTongue.ID)} feat, you can {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)}, {ToMarkdownLink<Models.Entities.Action>("Grab an Edge", Actions.Instances.GrabEdge.ID)}, and {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} with your tongue at a distance that is 5 feet beyond your normal reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("016ee023-9327-43bf-8c87-1a1ca9a48496"), Heritages.Instances.SnaptongueGrippli.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Grippli.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fee57c7a-3129-4396-8b0b-3d530fa7a33e"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
