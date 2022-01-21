using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CascadeBearersFlexibility : Template
    {
        public static readonly Guid ID = Guid.Parse("a7591947-ce3c-4a1d-a08e-1affcd265478");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cascade Bearers Flexibility",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("642ee6d0-3914-4b75-b910-b17cc3cf4128"), Type = TextBlockType.Text, Text = $"You call upon your Cascade Bearer training to help you adjust a spell for the current situation. Until the end of your turn, you gain a single {ToMarkdownLink<Models.Entities.Trait>("metamagic", Traits.Instances.Metamagic.ID)} feat from the druid class or the wizard class that has a level requirement of no more than half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d1919922-71fd-4475-87d0-2d057cfa3e4b"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("29a0a851-68aa-4e16-8b55-731af1b693cb"), "Cascade Bearers affiliation.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5410600-c33e-4129-bb87-a99aa22ec025"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
