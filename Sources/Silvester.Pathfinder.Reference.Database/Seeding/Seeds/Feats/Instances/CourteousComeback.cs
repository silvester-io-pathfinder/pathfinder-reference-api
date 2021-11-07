using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourteousComeback : Template
    {
        public static readonly Guid ID = Guid.Parse("70dd9d7e-3dd8-44f9-b842-7f03cd56dca0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courteous Comeback",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically fail a Diplomacy check.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8f51898-617d-4fac-81e9-4706bba44f0e"), Type = TextBlockType.Text, Text = "~ Access: Keleshite nationality" };
            yield return new TextBlock { Id = Guid.Parse("8587c548-8270-413e-ab39-a6040b9f1e0f"), Type = TextBlockType.Text, Text = "You grew up in the proud Padishah Empire, where even insults have a certain poetic wit. Reroll the triggering Diplomacy check, using the second result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bae1078-1a21-4e6d-8820-9b925a857eb3"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
