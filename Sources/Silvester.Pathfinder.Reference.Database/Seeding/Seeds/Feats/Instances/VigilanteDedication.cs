using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VigilanteDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("8c8457b5-1525-4c05-9911-f077ba986c7f");

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
            yield return new TextBlock { Id = Guid.Parse("eef27b5a-58b8-48ef-b386-00ff2058c0ca"), Type = TextBlockType.Text, Text = "You have two identities, each with its own name, alignment, and abilities. Your social identity is an upstanding member of society, while your vigilante identity is a skilled and cunning warrior. Neither of these identities is a false front; you really are both of these people, and as such, your two identities can be at most one alignment step from each other (for instance, you could be neutral in one identity and neutral evil in the other, but not chaotic evil in the other). If someone attempts to discern your other identity, they must use a (action: Seek) action to attempt a Perception check against your Deception DC, as if you were using the (action: Impersonate) action. Your Deception DC against such attempts is 20 + your proficiency modifier instead of the normal DC. Unlike with (action: Impersonate), you don’t have to attempt a Deception check to interact with someone to conceal your other identity – a check happens only if someone else specifically tries to uncover your other identity." };
            yield return new TextBlock { Id = Guid.Parse("25b2596a-15c7-4dbb-985f-47308fdb9d61"), Type = TextBlockType.Text, Text = "Changing from one identity to the other takes 1 minute and must be done out of sight from other creatures. As this process involves both physical changes such as clothing and makeup along with an altered state of mind, other effects that change your appearance don’t reduce the time required to change identities." };
            yield return new TextBlock { Id = Guid.Parse("ade4e19f-c347-4cb9-9679-f05221184797"), Type = TextBlockType.Text, Text = "Your two identities are completely distinct. You have your current identity’s alignment for effects that rely on alignment, though you are eligible for abilities that require a certain alignment (such as a cleric’s deity) only if both of your identities qualify. Checks to (action: Recall Knowledge) about one of your identities don’t reveal information about the other unless the person attempting the check knows both identities are the same person. Effects that detect you based on your identity, such as the (spell: detect alignment) spell, work only if you are currently in the identity the effect is trying to detect; otherwise, the effect fails as if the target didn’t exist." };
            yield return new TextBlock { Id = Guid.Parse("c69f7515-94a7-4298-8ee2-6fd04dc396ea"), Type = TextBlockType.Text, Text = "To maintain the separation between your identities, some of your abilities have one of two traits: (trait: social) or (trait: vigilante). You can use social feats only while in your social identity. Your class feats and vigilante feats are associated with your vigilante identity, and using them while in your social identity risks exposing you as a vigilante. This means that if you were particularly meek or inconspicuous before you took this feat, your identity could be at greater risk of exposure. If your identity is exposed to the public, you lose the benefits of Vigilante Dedication to disguising yourself, but you can otherwise use both (trait: social) and (trait: vigilante) abilities in either identity unless they rely on your identity being a secret. You can use feats that don’t have either trait regardless of your current identity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c7c33427-29ea-4286-a894-187da48de1cf"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7673a0fd-2c0f-4ae5-954c-ce5304e32e90"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
