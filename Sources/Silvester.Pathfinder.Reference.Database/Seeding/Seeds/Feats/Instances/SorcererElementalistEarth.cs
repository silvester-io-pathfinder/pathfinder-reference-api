using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("0c37679b-4afe-438f-83c6-8c7dd0079e41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Elementalist - Earth",
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
            yield return new TextBlock { Id = Guid.Parse("d0549ef7-35b3-41ec-bce0-777135e06a11"), Type = TextBlockType.Text, Text = "You replace your initial bloodline spell with the initial earth elemental focus spell ((spell: crushing ground)), and your advanced bloodline spell (if you get it) with the advanced earth elemental focus spell ((spell: stone lance))." };
            yield return new TextBlock { Id = Guid.Parse("23c4c18a-423e-4506-b9fa-ae223223ace4"), Type = TextBlockType.Text, Text = "You can only select this option if your bloodline&#39;s elemental type is earth." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40c29121-bae8-4546-8e2e-f469ce849350"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
