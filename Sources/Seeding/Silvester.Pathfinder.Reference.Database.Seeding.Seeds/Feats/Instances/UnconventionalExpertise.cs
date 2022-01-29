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
    public class UnconventionalExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("5caa8cf4-6c2d-4fa8-b73c-eef7ff523a0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unconventional Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("f178d071-b715-4b47-9851-29f210474501"), Type = TextBlockType.Text, Text = $"You've continued to advance your powers using your unconventional weapon. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency in the weapon you chose for {ToMarkdownLink<Models.Entities.Feat>("Unconventional Weaponry", Feats.Instances.UnconventionalWeaponry.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("80f20475-e684-4d1c-965d-d534475f8965"), Feats.Instances.UnconventionalWeaponry.ID);
            builder.Manual(Guid.Parse("e18e287c-a93f-44f7-bd16-0352a0a4a430"), "Trained in the weapon you chose for Unconventional Weaponry.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("140ca3d3-c973-48c6-b261-2b8c5cfe10f4"), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6cd9172-cfef-4b0c-8aaa-23307dcdfce8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
