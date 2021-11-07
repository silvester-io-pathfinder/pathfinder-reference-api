using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("739bc4c0-1f53-471d-abf7-98fd9b59809f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Master",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0eabdc78-8f95-4984-90a6-3a839ade967f"), Type = TextBlockType.Text, Text = "Your eidolon gains a bevy of lower-level spells. Choose an innate spell of your eidolon’s tradition of each of the spell levels from 1 to 7 in which your eidolon doesn’t currently have an innate spell from (feat: Magical Adept). Your eidolon can cast each once per day as innate spells. You can swap these spells at every even level, but your eidolon can never know more than one spell of each spell level 1 through 7." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4a07392a-8a06-49a1-8aec-a246a7bb00ea"), Feats.Instances.MagicalAdept.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("755c8de8-d161-4f80-86e4-196ef119ec5f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
