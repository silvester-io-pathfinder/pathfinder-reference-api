using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PullOfStasis : Template
    {
        public static readonly Guid ID = Guid.Parse("627234aa-fbb0-42e5-9532-5b449567bedf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pull of Stasis",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f80cfe0e-9465-4f5c-aa4c-199feb05e495"), Type = TextBlockType.Text, Text = "Any time you hit with the soulforged weapon, the target takes a –10-foot penalty to its Speeds for 1 round. On a critical hit, the creature is immobilized for 1 round instead." };
            yield return new TextBlock { Id = Guid.Parse("7878ffe2-1f08-48c4-a0c2-e5ad302490d9"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You take a –10-foot penalty to all your Speeds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac3fb49d-6f3c-4938-9f4b-d6769a9758cd"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
