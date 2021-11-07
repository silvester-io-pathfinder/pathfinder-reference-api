using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PullOfStasis : Template
    {
        public static readonly Guid ID = Guid.Parse("f8bf6459-ae74-4c53-af1d-f94a4ab6970e");

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
            yield return new TextBlock { Id = Guid.Parse("5170c93e-7a71-45ad-abdf-db59a6accfbc"), Type = TextBlockType.Text, Text = "Any time you hit with the soulforged weapon, the target takes a –10-foot penalty to its Speeds for 1 round. On a critical hit, the creature is immobilized for 1 round instead." };
            yield return new TextBlock { Id = Guid.Parse("c7d83544-c90e-4655-9a36-3e80f8db8a71"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You take a –10-foot penalty to all your Speeds." };
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
                Id = Guid.Parse("fd1d2d73-d84b-41b8-a880-80df7c6cd33e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
