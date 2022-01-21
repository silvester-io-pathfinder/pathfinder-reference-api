using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagaambyanAttendantDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d8e6749e-d7a9-41d9-adbb-8037d123884c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magaambyan Attendant Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Magaambyan Attendant archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("979133b3-21f6-40d9-a1c8-30e86d536a71"), Type = TextBlockType.Text, Text = "You devote much of your study to halcyon magic. You gain the ability to cast a single arcane or primal cantrip of your choice, (as is normal for cantrips, it is heightened to a spell level equal to half your level, rounded up). If you weren't already, you become trained in that tradition's spell DCs and spell attack rolls, with Intelligence as your spellcasting ability if you choose arcane or Wisdom as your spellcasting ability if you choose primal." };
            yield return new TextBlock { Id = Guid.Parse("1db874c0-a639-499a-b784-0ef683c1dd6b"), Type = TextBlockType.Text, Text = "Regardless of whether you choose an arcane or primal cantrip, you also either become trained in Arcana or Nature, or an expert in one of those skills in which you were already trained." };
            yield return new TextBlock { Id = Guid.Parse("18de3936-6550-420d-b7c0-c003767f4aaf"), Type = TextBlockType.Text, Text = "When you gain this feat, choose to affiliate with the Cascade Bearers, Emerald Boughs, Rain–Scribes, Tempest-Sun Mages, or Uzunjati. This grants you additional feats available to only that branch." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("f6fc4ca0-8d98-4952-adfd-149c64af1480"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("ae71fce1-138a-4cca-94e6-787e2a0f010c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("87a56602-bb56-4723-a898-ea8342e76ffb"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            });
            builder.Manual(Guid.Parse("f5f571f3-9103-47dc-90d3-2d2d3b8de172"), "Member of the Magaambya of attendant rank.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5adc0993-1224-4d87-877a-bc33affc03d0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
