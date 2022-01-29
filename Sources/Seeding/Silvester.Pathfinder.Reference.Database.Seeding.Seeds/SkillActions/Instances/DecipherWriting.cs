using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class DecipherWriting : Template
    {
        public static readonly Guid ID = Guid.Parse("3f8194b0-46ef-45db-8ae3-9f23fd53396d");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Decipher Writing",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0a66c55f-c2c3-4e5b-a5df-e144d783f234"), Type = TextBlockType.Text, Text = "You attempt to decipher complicated writing or literature on an obscure topic. This usually takes 1 minute per page of text, but might take longer (typically an hour per page for decrypting ciphers or the like). The text must be in a language you can read, though the GM might allow you to attempt to decipher text written in an unfamiliar language using Society instead." };
            yield return new TextBlock { Id = Guid.Parse("f10e38d1-d2e5-4397-ab2b-2f44973d25f9"), Type = TextBlockType.Text, Text = "The DC is determined by the GM based on the state or complexity of the document. The GM might have you roll one check for a short text or a check for each section of a larger text." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Athletics.ID;
            yield return Skills.Instances.Crafting.ID;
            yield return Skills.Instances.Deception.ID;
            yield return Skills.Instances.Diplomacy.ID;
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Medicine.ID;
            yield return Skills.Instances.Nature.ID;
            yield return Skills.Instances.Occultism.ID;
            yield return Skills.Instances.Perception.ID;
            yield return Skills.Instances.Performance.ID;
            yield return Skills.Instances.Religion.ID;
            yield return Skills.Instances.Society.ID;
            yield return Skills.Instances.Stealth.ID;
            yield return Skills.Instances.Survival.ID;
            yield return Skills.Instances.Thievery.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d5dfe899-b152-43dd-9a2a-b6824796fe79"),
                CriticalSuccess = "You understand the true meaning of the text.",
                Success = "You understand the true meaning of the text. If it was a coded document, you know the general meaning but might not have a word-for-word translation.",
                Failure = "You can't understand the text and take a -2 circumstance penalty to further checks to decipher it.",
                CriticalFailure = "You believe you understand the text on that page, but you have in fact misconstrued its message."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("01cdf940-5e78-4213-a486-e2137e8678b5"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Entry-level philosphy treatise." };
            yield return new SkillActionExample { Id = Guid.Parse("b8127760-6381-4c80-88fd-87c6a9b9a337"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Complex code, such as a cipher." };
            yield return new SkillActionExample { Id = Guid.Parse("1104143e-ad5c-4176-ad4f-a0eef1a4378a"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Spymaster's code or advanced research notes." };
            yield return new SkillActionExample { Id = Guid.Parse("0a0bc7a9-2183-4047-8816-78efc2cc1b53"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Esoteric planar text written in metaphor by an ancient celestial." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a055ada2-de66-41a9-9dff-fdcd8d750812"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 234
            };
        }
    }
}
