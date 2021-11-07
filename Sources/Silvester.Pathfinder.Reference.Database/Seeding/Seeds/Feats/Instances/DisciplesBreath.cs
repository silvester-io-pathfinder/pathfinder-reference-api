using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisciplesBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("0840e84b-ace8-40d1-a3ed-77f46add69db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disciple's Breath",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f5c3426-cddc-4192-9d20-70df4909f934"), Type = TextBlockType.Text, Text = "You unleash your breath weapon without spending focus. This has the effects of your (spell: dragon breath) sorcerer bloodline spell, though it deals 9d6 damage instead of its usual damage, and you don’t have to cast it or spend a Focus Point. You can’t use Disciple’s Breath again for 1d4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f4df17eb-85f8-455d-8ec0-e4d3783f6311"), Feats.Instances.DragonDiscipleDedication.ID);
            builder.HaveSpecificSpell(Guid.Parse("c4fb517d-ba57-4044-a8fa-36f17175b29a"), Spells.Instances.DragonBreath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a32d711e-0cd2-409f-9c70-c4c30cf0abce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
