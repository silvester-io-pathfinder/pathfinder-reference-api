using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BizzareMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("43a703b0-f486-44b2-b571-343805e69a65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bizzare Magic",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76695af1-b166-4c7f-8d13-9823516f673b"), Type = TextBlockType.Text, Text = $"You can draw upon strange variations in your spellcasting, whether or not you can cast occult spells. The DCs to {ToMarkdownLink<Models.Entities.Feat>("Recognize Spells", Feats.Instances.RecognizeSpell.ID)} you cast and {ToMarkdownLink<Models.Entities.SkillAction>("Identify Magic", SkillActions.Instances.IdentifyMagic.ID)} you use increase by 5." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("fd3a7e57-c964-4c3d-adc1-2fe8dd522426"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3e99c8e-2c58-4297-85f0-f9c65e564f28"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
