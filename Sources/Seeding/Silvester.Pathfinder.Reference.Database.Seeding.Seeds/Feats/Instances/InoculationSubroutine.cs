using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InoculationSubroutine : Template
    {
        public static readonly Guid ID = Guid.Parse("8337794c-cb2e-4f32-ad4a-238856d150a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inoculation Subroutine",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4de8b937-8881-4f58-b88c-f7c0512b1ab2"), Type = TextBlockType.Text, Text = "Your nanites reject diseases with ease. Each time you succeed at a Fortitude save against an ongoing disease, you reduce its stage by 2, or by 1 against a (trait: virulent) disease. Each critical success you achieve against an ongoing disease reduces its stage by 3, or by 2 against a (trait: virulent) disease." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa747654-ef62-4cb2-92bf-9fe2d1ef1f3f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
