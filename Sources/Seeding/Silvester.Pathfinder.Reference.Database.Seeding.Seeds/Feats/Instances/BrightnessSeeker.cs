using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrightnessSeeker : Template
    {
        public static readonly Guid ID = Guid.Parse("21e3083f-8c79-451b-b3f4-3654695771ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brightness Seeker",
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
            yield return new TextBlock { Id = Guid.Parse("b361e92b-5ae6-4c0a-adb6-342739178fb6"), Type = TextBlockType.Text, Text = $"Once per day, you can spend 10 minutes studying your surroundings in search of omens related to a particular course of action to cast {ToMarkdownLink<Models.Entities.Spell>("augury", Spells.Instances.Augury.ID)} as an innate divine spell. Unless the result of the {ToMarkdownLink<Models.Entities.Spell>("augury", Spells.Instances.Augury.ID)} was “nothing,” you gain the {ToMarkdownLink<Models.Entities.Feat>("Call Upon the Brightness", Feats.Instances.CallUponTheBrightness.ID)} reaction for the next 30 minutes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6a17d69-545c-4958-94a2-aca84f15b451"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
