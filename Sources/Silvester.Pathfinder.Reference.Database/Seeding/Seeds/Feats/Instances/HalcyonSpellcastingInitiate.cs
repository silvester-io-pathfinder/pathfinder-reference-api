using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalcyonSpellcastingInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("0e194a33-8cff-4dc5-a314-39cb04d4cb10");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halcyon Spellcasting Initiate",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c1fae1e-c1d9-4742-a675-baf561880b0a"), Type = TextBlockType.Text, Text = "Your knowledge of halcyon magic increases. You gain two common 2nd-level halcyon spells and two 3rd-level halcyon spells. You also gain a 2nd-level halcyon spell slot and a 3rd-level halcyon spell slot. These and all future halcyon spell slots work like the 1st-level halcyon spell slot you gained from (feat: Halcyon Speaker Dedication)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2a37b96b-1ee0-43fa-ade6-60cf37d8dbb8"), Feats.Instances.HalcyonSpeakerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6574d02-c108-48ec-a8d8-6d56729743ed"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
