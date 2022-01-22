using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GarudaMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("9c11c11a-14f4-4029-8f90-e375548aafb1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Garuda Magic",
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
            yield return new TextBlock { Id = Guid.Parse("d553a629-2c11-43da-b00f-4a675bfa23b4"), Type = TextBlockType.Text, Text = $"You are descended from the wondrous garudas, and their keen senses manifest in your magical prowess. You can cast {ToMarkdownLink<Models.Entities.Spell>("blur", Spells.Instances.Blur.ID)} and {ToMarkdownLink<Models.Entities.Spell>("see invisibility", Spells.Instances.SeeInvisibility.ID)} each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6b295380-e1c3-4654-a236-01834daf3eed"), Feats.Instances.Plumekith.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c531791-a303-4c2c-b3fd-4ac1ef793d32"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
