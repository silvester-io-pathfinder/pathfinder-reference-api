using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TempestSunRedirection : Template
    {
        public static readonly Guid ID = Guid.Parse("bb3fefe2-0d7f-4297-8812-3d0de986b99e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tempest-Sun Redirection",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9b22b25-9ba4-4f90-b6a2-c25834d49e28"), Type = TextBlockType.Text, Text = "If the next action you use is to (activity: Cast a Spell) from your spell slots that damages other creatures, you can bend some of that spell’s offensive energy, protecting allies in the area and boosting your own defenses against certain foes. Select any number of targets of the spell and reduce the spell’s damage to those targets by an amount equal to the spell’s level. Until your next turn, when one of those targets damages you, that damage is reduced by twice the spell’s level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("18688bf3-8367-4d1b-aa55-a8fc4356f28e"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("6a7dd842-3f45-4a85-9184-2fce0485a72a"), "Tempest-Sun Mages affiliation");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a1ae0c7-9134-4c47-a82d-44cc66e327d8"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
