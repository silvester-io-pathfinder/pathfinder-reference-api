using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdditionalCircusTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("f6b5e30b-ac78-4b97-9332-53dd0fd4694d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Additional Circus Trick",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7f1954c-0e4a-43b1-96b4-0e252bb0d12a"), Type = TextBlockType.Text, Text = "Your signature trick can have one additional trait beyond the number provided in __Table 2: Trick Progression on page 63 of Pathfinder #151: The Show Must Go On__. If the trick trait has an associated skill (such as Intimidation with the (trait: fire) trait) and that skill is one of your trick checks, your checks with that skill to Perform a Trick aren't penalized if you Perform a Trick using a different skill." };
            yield return new TextBlock { Id = Guid.Parse("89070cbd-f0b5-48e2-891e-0317791b518b"), Type = TextBlockType.Text, Text = "For example, if your signature trick has Acrobatics and Intimidation as trick checks and you take this feat to add the (trait: fire) trait, you can Perform a Trick using Acrobatics (at no penalty), then Acrobatics again (at a -5 penalty), and then Intimidation (at no penalty)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("2f6050b6-6285-4365-be19-41b1d9e309a9"), "You must have a signature trick.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb248ed0-eb1c-4ae7-aeb4-d85173412aaf"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
