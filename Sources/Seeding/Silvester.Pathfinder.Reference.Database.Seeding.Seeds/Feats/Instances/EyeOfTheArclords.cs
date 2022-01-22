using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EyeOfTheArclords : Template
    {
        public static readonly Guid ID = Guid.Parse("f0dc3f6d-8ea9-42aa-8a77-8fdbffdc4a09");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eye of the Arclords",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4491a1aa-e905-4c24-8c9e-d914e443fabb"), Type = TextBlockType.Text, Text = $"~ Access: You are a member of the Arclords of Nex." };
            yield return new TextBlock { Id = Guid.Parse("eb16735d-4676-424d-a889-907e6917065d"), Type = TextBlockType.Text, Text = $"You open an incandescent third eye upon your forehead. The eye can remain open for 1 minute, and you can close it before then with a single action with the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait. It can remain open for 2 minutes if you're a master in Arcana, or 5 minutes if you're legendary." };
            yield return new TextBlock { Id = Guid.Parse("ce7cb279-6d8d-4673-9d20-87d879b04a13"), Type = TextBlockType.Text, Text = $"While the eye is open, you gain the following benefits: you gain the effects of the {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)} arcane innate spell from your {ToMarkdownLink<Models.Entities.Feat>("Arcane Sense", Feats.Instances.ArcaneSense.ID)} at the start of each of your turns without needing to cast the spell; you gain darkvision; you gain a +2 status bonus to Perception checks to {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} undetected and hidden creatures and to your Perception DC against {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)}. After your third eye closes, you are dazzled for an amount of time equal to how long you had it open." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("48e3822f-3cee-4f40-af19-50f513eb8d00"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
            builder.HaveSpecificFeat(Guid.Parse("ef805ac6-bd41-43f4-9707-466f98873588"), Feats.Instances.ArcaneSense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0602a2a-35f9-41a7-94a9-02fc7bbee4df"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
