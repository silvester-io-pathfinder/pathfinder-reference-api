using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("b037729d-2d0f-4d55-b9fe-27492911e1a1");

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
            yield return new TextBlock { Id = Guid.Parse("ea985b49-150e-4d0b-b458-e1b404f67f81"), Type = TextBlockType.Text, Text = $"Your eidolon gains a bevy of lower-level spells. Choose an innate spell of your eidolon's tradition of each of the spell levels from 1 to 7 in which your eidolon doesn't currently have an innate spell from {ToMarkdownLink<Models.Entities.Feat>("Magical Adept", Feats.Instances.MagicalAdept.ID)}. Your eidolon can cast each once per day as innate spells. You can swap these spells at every even level, but your eidolon can never know more than one spell of each spell level 1 through 7." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("013f6148-4386-4734-bef8-5b524db77422"), Feats.Instances.MagicalAdept.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46f2e16d-1b94-4bcd-91eb-d9853f9146d0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
