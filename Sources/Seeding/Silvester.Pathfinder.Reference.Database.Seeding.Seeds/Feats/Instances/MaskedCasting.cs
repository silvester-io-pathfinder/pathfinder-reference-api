using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaskedCasting : Template
    {
        public static readonly Guid ID = Guid.Parse("aacd9446-2a75-479b-987f-b953f0428fb5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Masked Casting",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You begin Casting a Spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fccda384-eb81-4a34-9121-ee2270bde8b7"), Type = TextBlockType.Text, Text = $"You harness the magical energy flowing through your eyeless mask to effortlessly protect you from {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} effects. You {ToMarkdownLink<Models.Entities.Action>("Avert your Gaze", Actions.Instances.AvertGaze.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("03433884-ad8d-41c7-abaa-e7014578c381"), Feats.Instances.HellknightSigniferDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e7d174e-0fb9-4e69-a1d7-696cf59384cf"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
