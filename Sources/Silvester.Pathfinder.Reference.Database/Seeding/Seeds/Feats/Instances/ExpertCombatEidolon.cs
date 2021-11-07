using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertCombatEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("ce1e7a6e-f028-438d-8c32-0cd3a6693be0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Combat Eidolon",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10a9d6fc-2d0b-4810-969d-664391233ee5"), Type = TextBlockType.Text, Text = "Your eidolon advances its capabilities in combat. Your eidolon becomes an expert in unarmed attacks. If you are an expert in unarmored defense, your eidolon also becomes an expert in unarmored defense. If you have weapon specialization, your eidolon also gains weapon specialization." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d9f64aaa-2e57-4ca9-b9a3-efbba801b2f3"), Feats.Instances.SummonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49a594a2-599a-48c4-95c0-e4bf436b9410"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
