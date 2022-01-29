using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VigilanteDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9850f195-f02b-43a0-840f-88ea1ae70397");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vigilante Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the vigilante archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8ea0140-5e7c-4a72-ab35-2039716c5142"), Type = TextBlockType.Text, Text = $"You have two identities, each with its own name, alignment, and abilities. Your social identity is an upstanding member of society, while your vigilante identity is a skilled and cunning warrior. Neither of these identities is a false front; you really are both of these people, and as such, your two identities can be at most one alignment step from each other (for instance, you could be neutral in one identity and neutral evil in the other, but not chaotic evil in the other). If someone attempts to discern your other identity, they must use a {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} action to attempt a Perception check against your Deception DC, as if you were using the {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)} action. Your Deception DC against such attempts is 20 + your proficiency modifier instead of the normal DC. Unlike with {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)}, you don't have to attempt a Deception check to interact with someone to conceal your other identity – a check happens only if someone else specifically tries to uncover your other identity." };
            yield return new TextBlock { Id = Guid.Parse("b5310cde-377a-44d2-b5b6-1f5e1559c673"), Type = TextBlockType.Text, Text = $"Changing from one identity to the other takes 1 minute and must be done out of sight from other creatures. As this process involves both physical changes such as clothing and makeup along with an altered state of mind, other effects that change your appearance don't reduce the time required to change identities." };
            yield return new TextBlock { Id = Guid.Parse("65920fae-3cb4-4800-a00d-50bb7c6c03ca"), Type = TextBlockType.Text, Text = $"Your two identities are completely distinct. You have your current identity's alignment for effects that rely on alignment, though you are eligible for abilities that require a certain alignment (such as a cleric's deity) only if both of your identities qualify. Checks to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about one of your identities don't reveal information about the other unless the person attempting the check knows both identities are the same person. Effects that detect you based on your identity, such as the {ToMarkdownLink<Models.Entities.Spell>("detect alignment", Spells.Instances.DetectAlignment.ID)} spell, work only if you are currently in the identity the effect is trying to detect; otherwise, the effect fails as if the target didn't exist." };
            yield return new TextBlock { Id = Guid.Parse("89124c50-8470-4706-8eea-1b5f07d66231"), Type = TextBlockType.Text, Text = $"To maintain the separation between your identities, some of your abilities have one of two traits: {ToMarkdownLink<Models.Entities.Trait>("social", Traits.Instances.Social.ID)} or {ToMarkdownLink<Models.Entities.Trait>("vigilante", Traits.Instances.Vigilante.ID)}. You can use social feats only while in your social identity. Your class feats and vigilante feats are associated with your vigilante identity, and using them while in your social identity risks exposing you as a vigilante. This means that if you were particularly meek or inconspicuous before you took this feat, your identity could be at greater risk of exposure. If your identity is exposed to the public, you lose the benefits of Vigilante Dedication to disguising yourself, but you can otherwise use both {ToMarkdownLink<Models.Entities.Trait>("social", Traits.Instances.Social.ID)} and {ToMarkdownLink<Models.Entities.Trait>("vigilante", Traits.Instances.Vigilante.ID)} abilities in either identity unless they rely on your identity being a secret. You can use feats that don't have either trait regardless of your current identity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("07a45693-82f2-458c-862c-4cf8e5e1d94c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3543982d-3a49-44f1-add8-52ed77e61b2f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
