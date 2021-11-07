using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicSorcererSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("046f91ef-2ddc-463a-ab79-55dd9d1becc4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Sorcerer Spellcasting",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2513a784-33cd-4816-8c74-8e2badea761f"), Type = TextBlockType.Text, Text = "You gain a 1st-level spell slot. At 6th level, you gain a 2nd-level spell slot and you can select one spell from your repertoire as a signature spell. At 8th level, you gain a 3rd-level spell slot. Each time you gain a spell slot of a new level from the sorcerer archetype, add a spell of the appropriate spell level to your repertoire: a common spell of your bloodline’s tradition, one of your bloodline’s granted spells, or another spell you have learned or discovered." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2235b480-db18-4777-9f0a-0069cd2d7173"), Feats.Instances.SorcererDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2131479-71a2-42b0-a323-fc46442647bb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
