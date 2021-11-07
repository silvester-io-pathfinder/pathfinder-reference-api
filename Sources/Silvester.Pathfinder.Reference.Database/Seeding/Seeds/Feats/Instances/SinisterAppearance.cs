using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SinisterAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("c816e9a0-eec9-4328-978e-9fedb1e122d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sinister Appearance",
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
            yield return new TextBlock { Id = Guid.Parse("8953d20e-d7ec-42f1-9f73-ebcbd37861bf"), Type = TextBlockType.Text, Text = "You possess horns, a tail, or red eyes, or could otherwise be mistaken for a tiefling. You gain the trained proficiency rank in Intimidation. If you would automatically become trained in Intimidation (from your background or class, for example), you instead become trained in a skill of your choice. You gain the (feat: Intimidating Glare) skill feat, as well as a +2 circumstance bonus on Deception checks to (action: Impersonate) when pretending to be a version of yourself who is a tiefling." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab02bfc5-3634-4e61-90fb-563dd9bc7ba1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
