using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UniversalVersatility : Template
    {
        public static readonly Guid ID = Guid.Parse("947cb1f2-fe04-4f0a-ba1c-95aa4821dd78");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Universal Versatility",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7018eb5e-1e2d-4be4-af52-e7c60d916105"), Type = TextBlockType.Text, Text = $"You can access the fundamental abilities of any school of magic. During your daily preparations, choose one of the eight school spells gained by 1st-level specialist wizards. You can use that school spell until your next daily preparations. When you {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)}, you can choose a different school spell from among those eight school spells, replacing the previous one. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("bd4ff514-809b-47cd-86d5-a231b795d7c7"), Classes.Instances.Wizard.ID);
            builder.HaveNoMagicSchool(Guid.Parse("2c40418e-5441-4a8f-8bf5-e3b17090d150"));
            builder.HaveSpecificFeat(Guid.Parse("fb5e0273-8f8d-4921-a890-bda5f5de2aa2"), Feats.Instances.HandOfTheApprentice.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d631bd9-c942-4601-93b0-cadf646167ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
