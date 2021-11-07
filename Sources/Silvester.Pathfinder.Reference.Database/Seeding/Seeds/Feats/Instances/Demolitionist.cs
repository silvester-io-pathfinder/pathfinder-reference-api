using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Demolitionist : Template
    {
        public static readonly Guid ID = Guid.Parse("5f714f98-0e83-4408-94cf-0453b8d4625c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demolitionist",
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
            yield return new TextBlock { Id = Guid.Parse("27a4f96c-a263-4af9-bf7c-855e696010f4"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("e3979b95-140d-48ea-9aff-ea579bb4d352"), Type = TextBlockType.Text, Text = "You know how to destroy objects with a well-placed explosion. Whenever you hit with a bomb (action: Strike) against a trap or an unattended object, you ignore the first 5 points of the object’s Hardness." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41216c2b-e2cf-4c45-bcd5-f73eb6964019"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
