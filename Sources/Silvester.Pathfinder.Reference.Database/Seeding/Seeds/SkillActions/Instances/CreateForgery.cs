using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class CreateForgery : Template
    {
        public static readonly Guid ID = Guid.Parse("0b15ba3f-b45a-4047-a86b-c8dafc9c50d0");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Create Forgery",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7b977866-bc53-4600-a439-0c4b4ff662cb"), Type = TextBlockType.Text, Text = "You create a forged document, usually over the course of a day or a week. You must have the proper writing material to create a forgery. When you Create a Forgery, the GM rolls a secret DC 20 Society check. If you succeed, the forgery is of good enough quality that passive observers can�t notice the fake. Only those who carefully examine the document and attempt a Perception or Society check against your Society DC can do so." };
            yield return new TextBlock { Id = Guid.Parse("2dacd2c6-ece3-4123-a0c9-935a2dcf007d"), Type = TextBlockType.Text, Text = "DC can do so. If the document�s handwriting doesn�t need to be specific to a person, you need only to have seen a similar document before, and you gain up to a +4 circumstance bonus to your check, as well as to your DC (the GM determines the bonus). To forge a specific person�s handwriting, you need a sample of that person�s handwriting." };
            yield return new TextBlock { Id = Guid.Parse("3480b6ee-b603-4f20-83a3-35d6abf7b230"), Type = TextBlockType.Text, Text = "If your check result was below 20, the forgery has some obvious signs of being a fake, so the GM compares your result to each passive observer�s Perception DC or Society DC, whichever is higher, using the success or failure results below. Once the GM rolls your check for a document, that same result is used against all passive observers� DCs no matter how many creatures passively observe that document." };
            yield return new TextBlock { Id = Guid.Parse("123128d2-2b56-455e-8244-978a08698efe"), Type = TextBlockType.Text, Text = "An observer who was fooled on a passive glance can still choose to closely scrutinize the documents on the lookout for a forgery, using different techniques and analysis methods beyond the surface elements you successfully forged with your original check. In that case, the observer can attempt a Perception or Society check against your Society DC (if they succeed, they know your document is a forgery)." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c7241021-de8c-4a19-9384-63f15f63f9be"),
                Success = "The observer does not detect the forgery.",
                Failure = "The observer knows your document is a forgery.",
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Downtime.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("268a4151-ae3a-45a3-a12a-0339f0843cf5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 251
            };
        }
    }
}
