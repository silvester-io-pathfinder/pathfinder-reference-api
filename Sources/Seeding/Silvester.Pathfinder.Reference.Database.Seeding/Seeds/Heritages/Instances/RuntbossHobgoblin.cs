using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class RuntbossHobgoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("5a4568ea-cf19-40c7-b0c7-bfdc09f9cb47");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Runtboss Hobgoblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d98f6032-46bf-4ed2-b8ff-688e348ffb3d"), Type = TextBlockType.Text, Text = "You come from a long line of hobgoblins who commanded goblins. You are smaller than other hobgoblins, but goblins still listen to any commands you bellow. You gain the Group Coercion skill feat. If you roll a success on an Intimidation check to Coerce a goblin (but not other creatures with the goblin trait), you get a critical success instead; if you roll a critical failure, you get a failure instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("e9604646-80b8-491e-a824-1f54c5f89f8e"), Feats.Instances.GroupCoercion.ID);
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse("c80666a8-c41e-43d6-8952-cca5267b0d42"), Skills.Instances.Intimidation.ID, SkillActions.Instances.Coerce.ID, RollResult.Success, becomes: RollResult.CriticalSuccess, addendum: "When specifically targeting a goblin (but not other creatures with the goblin trait).");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse("fac7e483-9cd5-461a-9bb8-dd8aef9aa8d7"), Skills.Instances.Intimidation.ID, SkillActions.Instances.Coerce.ID, RollResult.CriticalFailure, becomes: RollResult.Failure, addendum: "When specifically targeting a goblin (but not other creatures with the goblin trait).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdc540b3-e639-4905-82f4-6f004a70463a"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 49
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Hobgoblin.ID;
        }
    }
}
