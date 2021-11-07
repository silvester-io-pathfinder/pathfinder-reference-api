using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormRetention : Template
    {
        public static readonly Guid ID = Guid.Parse("9a69075d-e7d5-40b9-b22a-57f170e30887");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form Retention",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5a6a8d5-90e7-4941-821a-6354c7bc491b"), Type = TextBlockType.Text, Text = "You have trained your mind and body to tolerate polymorph magic for longer periods of time, so long as you prepare for the change appropriately. When preparing a polymorph spell that lasts 1 minute and grants a battle form, you can prepare the spell in a slot 2 levels higher than normal. This doesn’t grant any of the normal benefits of heightening a spell, but the spell lasts up to 10 minutes. For example, if you prepared (spell: animal form) in a 4th-level slot with Form Retention, you would cast a 2nd-level (spell: animal form) that lasts for up to 10 minutes. If the spell can be Dismissed, that doesn’t change." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d0efcfc-70c7-4d4c-bd4e-15fc563261c1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
