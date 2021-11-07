using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("84f1d1b4-3eab-4862-bcc0-4aa2b63f1eb1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Heart",
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
            yield return new TextBlock { Id = Guid.Parse("1c331119-aea4-4546-b460-4c4be4b9ff43"), Type = TextBlockType.Text, Text = "Your eidolon’s heart beats with energy. Choose an energy damage type other than force. One of its unarmed attacks changes its damage type to the chosen type, and it gains resistance to that type equal to half your level (minimum 1)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4eeff75-f2f1-4598-8422-242a675471fa"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
