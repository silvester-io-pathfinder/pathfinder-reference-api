using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisciplesBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("27190aba-11d0-4d46-ae0e-2cfa1517f6e2");

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
            yield return new TextBlock { Id = Guid.Parse("f480a0aa-f285-4c0f-a155-9b24f171f91b"), Type = TextBlockType.Text, Text = "You unleash your breath weapon without spending focus. This has the effects of your (spell: dragon breath) sorcerer bloodline spell, though it deals 9d6 damage instead of its usual damage, and you don’t have to cast it or spend a Focus Point. You can’t use Disciple’s Breath again for 1d4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("787e2780-854b-488e-8087-e6d098f166e3"), Feats.Instances.DragonDiscipleDedication.ID);
            builder.HaveSpecificSpell(Guid.Parse("fcc839d7-3589-4f9a-a8eb-9d678af341bf"), Spells.Instances.DragonBreath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5f89fa6-3d18-44a4-bcc7-6dbd6677ec7d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
