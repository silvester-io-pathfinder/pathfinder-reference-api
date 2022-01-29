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
    public class MountainStance : Template
    {
        public static readonly Guid ID = Guid.Parse("2e163950-cbcc-4fd0-a554-214301f9f768");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mountain Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06cb3a2f-72fc-46a9-b696-c998e04ca396"), Type = TextBlockType.Text, Text = $"You enter the stance of an implacable mountain – a technique first discovered by dwarven monks – allowing you to strike with the weight of an avalanche. The only {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you can make are falling stone unarmed attacks. These deal 1d8 bludgeoning damage; are in the brawling group; and have the {ToMarkdownLink<Models.Entities.Trait>("forceful", Traits.Instances.Forceful.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits." };
            yield return new TextBlock { Id = Guid.Parse("607ed5a8-6b2a-4616-a298-309af3d59a20"), Type = TextBlockType.Text, Text = $"While in Mountain Stance, you gain a +4 status bonus to AC and a +2 circumstance bonus to any defenses against being {ToMarkdownLink<Models.Entities.SkillAction>("Shoved", SkillActions.Instances.Shove.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Tripped", SkillActions.Instances.Trip.ID)}. However, you have a Dexterity modifier cap to your AC of +0, meaning you don't add your Dexterity to your AC, and your Speeds are all reduced by 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c037ca72-ff9e-43cc-b241-4bfd91c43705"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0e7060ae-09e0-4c90-bfa5-4a68f52c352a"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("970bc1bb-e32d-40ac-a5ac-da553938b1ba"), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa0fe518-fa52-4bc0-afb9-b908cf2a88f3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
