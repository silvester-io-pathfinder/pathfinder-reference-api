using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CleansingSubroutine : Template
    {
        public static readonly Guid ID = Guid.Parse("e9c7263a-5fdf-4ff0-a592-c19e54ee1618");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cleansing Subroutine",
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
            yield return new TextBlock { Id = Guid.Parse("e89a186e-a31d-42e1-97bc-7ed125e22f4c"), Type = TextBlockType.Text, Text = "Your nanites help purge your body of harmful chemicals and toxins. Each time you succeed at a Fortitude save against an ongoing poison, you reduce its stage by 2, or by 1 against a (trait: virulent) poison. Each critical success you achieve against an ongoing poison reduces its stage by 3, or by 2 against a (trait: virulent) poison." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5705b5b6-1330-4a67-a656-547d0fa16e48"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
