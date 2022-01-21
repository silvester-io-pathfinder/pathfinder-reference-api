using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourteousComeback : Template
    {
        public static readonly Guid ID = Guid.Parse("705fd2d9-d75c-46e8-9026-75f00e5be595");

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
            yield return new TextBlock { Id = Guid.Parse("95719b4d-a352-483b-8155-c5557000a02a"), Type = TextBlockType.Text, Text = $"~ Access: Keleshite nationality" };
            yield return new TextBlock { Id = Guid.Parse("e0a306f1-a720-47f3-96a5-f84411056659"), Type = TextBlockType.Text, Text = $"You grew up in the proud Padishah Empire, where even insults have a certain poetic wit. Reroll the triggering Diplomacy check, using the second result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5aeff23e-25d0-499d-aea4-32c4f3fe03c2"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
