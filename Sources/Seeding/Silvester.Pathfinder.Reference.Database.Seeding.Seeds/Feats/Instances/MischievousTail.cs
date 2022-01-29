using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MischievousTail : Template
    {
        public static readonly Guid ID = Guid.Parse("e3519abb-475e-457f-9428-8c0adf897ac5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mischievous Tail",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd40a469-0edb-4b76-9ce7-e6d4efd83513"), Type = TextBlockType.Text, Text = $"Your tail can bedevil your foes. You can {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} creatures with your tail, even if you don't have a free hand. All restrictions of {ToMarkdownLink<Models.Entities.Feat>("Skillful Tail", Feats.Instances.SkillfulTail.ID)} otherwise continue to apply. If you have {ToMarkdownLink<Models.Entities.Feat>("Smashing Tail", Feats.Instances.SmashingTail.ID)}, your tail unarmed attack gains the {ToMarkdownLink<Models.Entities.Trait>("disarm", Traits.Instances.Disarm.ID)} and {ToMarkdownLink<Models.Entities.Trait>("trip", Traits.Instances.Trip.ID)} traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("de52b6f6-7b74-4de6-bb6f-fa23399c299d"), Feats.Instances.SkillfulTail.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79da566f-d682-4b99-9130-2e7917484ed4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
