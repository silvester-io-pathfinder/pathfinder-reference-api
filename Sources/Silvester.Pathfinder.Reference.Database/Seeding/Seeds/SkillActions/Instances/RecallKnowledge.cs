using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class RecallKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("94408610-48ae-439d-8ed8-8dc3b663c3d5");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Recall Knowledge",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("03bab0d4-f5c9-414c-b80a-65251ecad2ce"), Type = TextBlockType.Text, Text = "To remember useful information on a topic, you can attempt to Recall Knowledge. You might know basic information about something without needing to attempt a check, but Recall Knowledge requires you to stop and think for a moment so you can recollect more specific facts and apply them. You might even need to spend time investigating first. For instance, to use Medicine to learn the cause of death, you might need to conduct a forensic examination before attempting to Recall Knowledge." };
            yield return new TextBlock { Id = Guid.Parse("4faa8022-01a3-4438-856c-d0d99e49f321"), Type = TextBlockType.Text, Text = "You attempt a skill check to try to remember a bit of knowledge regarding a topic related to that skill. The GM determines the DCs for such checks and which skills apply." };
            yield return new TextBlock { Id = Guid.Parse("2284c7b7-a861-439f-b271-979d8adebdd0"), Type = TextBlockType.Text, Text = "The following skills can be used to Recall Knowledge, getting information about the listed topics. In some cases, you can get the GM�s permission to use a different but related skill, usually against a higher DC than normal. Some topics might appear on multiple lists, but the skills could give different information. For example, Arcana might tell you about the magical defenses of a golem, whereas Crafting could tell you about its sturdy resistance to physical attacks." };
            yield return new TextBlock { Id = Guid.Parse("a56722da-8547-4f84-a5d7-86b2bd9a0bdf"), Type = TextBlockType.Enumeration, Text = "Arcana - Arcane theories, magical traditions, creatures of arcane significance, and arcane planes." };
            yield return new TextBlock { Id = Guid.Parse("9f2eb986-4122-4d8c-9211-b98de3ee6f26"), Type = TextBlockType.Enumeration, Text = "Crafting - Alchemical reactions and creatures, item value, engineering, unusual materials, and constructs." };
            yield return new TextBlock { Id = Guid.Parse("103b03d9-ddf1-47be-becd-5363323eae80"), Type = TextBlockType.Enumeration, Text = "Lore - The subject of the Lore skill�s subcategory." };
            yield return new TextBlock { Id = Guid.Parse("0069a35f-67ec-4eb0-84d0-e0e2e666b12a"), Type = TextBlockType.Enumeration, Text = "Medicine - Diseases, poisons, wounds, and forensics." };
            yield return new TextBlock { Id = Guid.Parse("8c0f1327-066a-4ade-88c4-23171d7c514f"), Type = TextBlockType.Enumeration, Text = "Nature - The environment, flora, geography, weather, creatures of natural origin, and natural planes." };
            yield return new TextBlock { Id = Guid.Parse("a8d38291-c731-4805-85b5-3d6ce3045145"), Type = TextBlockType.Enumeration, Text = "Occultism - Ancient mysteries, obscure philosophy, creatures of occult significance, and esoteric planes." };
            yield return new TextBlock { Id = Guid.Parse("8e6b8828-8073-4ab9-b5a0-0a99ed0bb9f4"), Type = TextBlockType.Enumeration, Text = "Religion - Divine agents, divine planes, theology, obscure myths, and creatures of religious significance." };
            yield return new TextBlock { Id = Guid.Parse("dd270a10-44ea-4fe4-85db-28385d775750"), Type = TextBlockType.Enumeration, Text = "Society - Local history, key personalities, legal institutions, societal structure, and humanoid culture." };
            yield return new TextBlock { Id = Guid.Parse("c71bfa74-5889-405b-9d88-b0ae8d97372b"), Type = TextBlockType.Text, Text = "The GM might allow checks to Recall Knowledge using other skills. For example, you might assess the skill of an acrobat using Acrobatics. If you're using a physical skill (like in this example), the GM will most likely have you use a mental ability score - typically Intelligence - instead of the skill's normal physical ability score." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Crafting.ID;
            yield return Skills.Instances.Medicine.ID;
            yield return Skills.Instances.Nature.ID;
            yield return Skills.Instances.Occultism.ID;
            yield return Skills.Instances.Religion.ID;
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e44f7688-841e-4e84-ac9c-9c54e9673da0"),
                CriticalSuccess = "You recall the knowledge accurately and gain additional information or context.",
                Success = "You recall the knowledge accurately or gain a useful clue about your current situation.",
                CriticalFailure = "You recall incorrect information or gain an erroneous or misleading clue."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("bc616f6e-af30-4910-94f8-7b2f04b9a96c"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Name of a ruler, key noble, or major deity." };
            yield return new SkillActionExample { Id = Guid.Parse("d8e6136a-990c-4a38-a1ea-e89bbd04b9b1"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Line of succession for a major noble family, core doctrines of a major deity." };
            yield return new SkillActionExample { Id = Guid.Parse("ba339890-011a-48ff-b70b-e959741c16ad"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Genealogy of a minor noble, teachings of an ancient priest." };
            yield return new SkillActionExample { Id = Guid.Parse("9618e76e-a7c4-4fcc-b58d-ed407d8bf795"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Hierarchy of a genie noble court, major extraplanar temples of a deity." };
            yield return new SkillActionExample { Id = Guid.Parse("bc494ce6-46df-42fc-88b8-72b5287a62da"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Existence of a long-lost noble heir, secret doctrines of a religion." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18c6b445-07e4-47ef-a10a-ee0a572618f9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 238
            };
        }
    }
}
