using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SynergisticSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("0d65c6ae-6c76-46af-9f6f-e3d47264ba51");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Synergistic Spell",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5272a3be-790a-4863-aef8-cf3bf0dc2608"), Type = TextBlockType.Text, Text = "You combine your synergy and spells into a fantastic web of magic, allowing you to cast two spells at once. If the next action you use is to (activity: Cast a Spell) from one of your halcyon spell slots, after that spell resolves, you can Cast another Spell as a free action. This spell must be cast from one of your halcyon spell slots and be a spell that would normally take two actions to cast." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("57ea9f7d-26af-48e9-83cb-fc1f50fb5cda"), Feats.Instances.HalcyonSpellcastingInitiate.ID);
            builder.HaveSpecificFeat(Guid.Parse("6094002a-6e63-4958-b807-5e265f9a339f"), Feats.Instances.FulminatingSynergy.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("72856fbf-d90f-44ed-b6c4-bc97b7b1da9b"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("77e3d196-4c86-4985-b056-aeb9fc3ef81f"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25105882-6f43-441b-8ae2-3be9b5a97939"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
