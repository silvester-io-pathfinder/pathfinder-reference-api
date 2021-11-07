using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FirearmExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("122cc140-4f0a-4856-aa05-88eed5acc327");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Firearm Expert",
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
            yield return new TextBlock { Id = Guid.Parse("c6d60359-7add-44f1-9d02-09caee7b3966"), Type = TextBlockType.Text, Text = "You’ve become an expert with your chosen weapons. Your proficiency ranks for simple and martial crossbows and simple and martial firearms increase to expert." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3391de4f-3042-4b2e-86e6-fa6323d0103c"), Feats.Instances.GunslingerDedication.ID);
            builder.AddOr(Guid.Parse("99a0123b-8d0f-41b2-9f3d-74d808a0556c"), or => 
            {
                or.HaveAnyWeaponCategorySpecificProficiency(Guid.Parse("bf45795f-db24-4d13-a8a1-785ed3dc6386"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyWeaponGroupSpecificProficiency(Guid.Parse("d0a0da39-4215-43db-af82-761b50c0da74"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyMeleeWeaponSpecificProficiency(Guid.Parse("26dc7c14-434f-4fa2-b0ce-4791f1abfef7"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyRangedWeaponSpecificProficiency(Guid.Parse("21a05afc-9a4c-4467-aeb7-e8ec04f16aca"), Proficiencies.Instances.Expert.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60ee14eb-4307-4fed-bb7b-7298ad6ae02e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
