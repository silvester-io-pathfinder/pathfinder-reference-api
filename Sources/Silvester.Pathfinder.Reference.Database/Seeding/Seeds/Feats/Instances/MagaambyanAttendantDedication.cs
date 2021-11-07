using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagaambyanAttendantDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("f7ab2ab1-66db-4dac-9479-87b427bbca8e");

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
            yield return new TextBlock { Id = Guid.Parse("5345536e-4710-4654-834b-af445dc4dd24"), Type = TextBlockType.Text, Text = "You devote much of your study to halcyon magic. You gain the ability to cast a single arcane or primal cantrip of your choice, (as is normal for cantrips, it is heightened to a spell level equal to half your level, rounded up). If you weren’t already, you become trained in that tradition’s spell DCs and spell attack rolls, with Intelligence as your spellcasting ability if you choose arcane or Wisdom as your spellcasting ability if you choose primal." };
            yield return new TextBlock { Id = Guid.Parse("62a028a8-2b1b-4490-be7f-06867c238a98"), Type = TextBlockType.Text, Text = "Regardless of whether you choose an arcane or primal cantrip, you also either become trained in Arcana or Nature, or an expert in one of those skills in which you were already trained." };
            yield return new TextBlock { Id = Guid.Parse("0a2b1e63-a842-43b5-a301-fd383eb0b825"), Type = TextBlockType.Text, Text = "When you gain this feat, choose to affiliate with the Cascade Bearers, Emerald Boughs, Rain–Scribes, Tempest-Sun Mages, or Uzunjati. This grants you additional feats available to only that branch." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("1e44b13b-6367-4d5f-953c-f19f60f09943"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("4774e63a-7ecb-4642-91d9-92fe2c6afb19"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("9c9a7db9-467a-4a13-97d2-cb36dc6910e9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            });
            builder.Manual(Guid.Parse("16df64ef-b74b-44c3-81bf-8db1413a9cb3"), "Member of the Magaambya of attendant rank.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c194bc4a-3cce-4142-bb6e-9706470104f6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
