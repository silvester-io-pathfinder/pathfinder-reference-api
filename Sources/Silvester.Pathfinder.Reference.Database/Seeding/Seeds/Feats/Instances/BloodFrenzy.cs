using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("d6cc4d33-bb2b-4363-beea-b566d4fccdeb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blood Frenzy",
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
            yield return new TextBlock { Id = Guid.Parse("656473d3-4095-405d-96cb-6460027c8616"), Type = TextBlockType.Text, Text = "Your eidolon flies into a frenzy. It gains the benefits of (spell: boost eidolon) and gains temporary HP equal to your level, but takes a –2 penalty to AC. It can’t voluntarily end the frenzy or start another frenzy while in the frenzy. The frenzy lasts for 1 minute, after which your eidolon is fatigued for 1 minute and can’t start another frenzy for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e0bc0260-951a-4644-8651-0ee696005cc7"), Feats.Instances.BloodlettingClaws.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b36e4f8e-5e27-43de-8d7d-64de5b820b0b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
