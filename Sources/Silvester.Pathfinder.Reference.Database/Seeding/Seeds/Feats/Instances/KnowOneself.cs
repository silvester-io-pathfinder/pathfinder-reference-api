using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnowOneself : Template
    {
        public static readonly Guid ID = Guid.Parse("2e4315b3-81ba-4ba0-b1fe-786cb4043327");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Know Oneself",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll a critical failure on a saving throw against an emotion effect.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed336e56-dc7f-4107-b48b-881458a609ad"), Type = TextBlockType.Text, Text = "~ Access: Vudrani ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("07e1a3d3-92c1-4f02-be59-cfc6ef51562f"), Type = TextBlockType.Text, Text = "You center yourself and call to mind the Vudrani monastic ideals of mindfulness and self-knowledge. You fail the save against the (trait: emotion) effect instead of critically failing." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0de1030e-d576-4ac8-8265-e42e45c0224f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
